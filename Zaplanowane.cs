using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepcjaWHotelu
{
    public partial class Zaplanowane : UserControl
    {
        public void Populate(string id, string dataod, string datado, string iloscos, string parking, string jedzenie, string spa, string silownia, string imie, string nazwisko, string nrtel)
        {
            if (parking == "True")
            {
                parking = "✅";
            }else if(parking !="True")
            {
                parking = "❎";
            }
            if (jedzenie == "True")
            {
                jedzenie = "✅";
            }
            else if (jedzenie != "True")
            {
                jedzenie = "❎";
            }
            if (spa == "True")
            {
                spa = "✅";
            }
            else if (spa != "True")
            {
                spa = "❎";
            }
            if (silownia == "True")
            {
                silownia = "✅";
            }
            else if (silownia != "True")
            {
                silownia = "❎";
            }
            dg.Rows.Add(id, imie, nazwisko, nrtel, dataod, datado, iloscos, parking, jedzenie, spa, silownia);
        }


        public void Apped()
        {
            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"..\..\passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();

            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MySqlCommand q1 = new MySqlCommand($"SELECT * FROM `rezerwacja`;", cnn);
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                Console.WriteLine("Connection Open Z!");
                adapter = new MySqlDataAdapter(q1);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString());
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }
        public Zaplanowane()
        {
            InitializeComponent();
            dg.ColumnCount = 11;
            dg.Columns[0].Name = "Numer rezerwacji";
            dg.Columns[1].Name = "Imie";
            dg.Columns[2].Name = "Nazwisko";
            dg.Columns[3].Name = "Numer telefonu";
            dg.Columns[4].Name = "Data od";
            dg.Columns[5].Name = "Data do";
            dg.Columns[6].Name = "Ilość osób";
            dg.Columns[7].Name = "Parking";
            dg.Columns[8].Name = "Wyżywienie";
            dg.Columns[9].Name = "SPA";
            dg.Columns[10].Name = "Siłownia";
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.MultiSelect = false;
            Apped();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dg.Rows.Clear();
            Apped();
        }
    }
}

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
        /// <summary>
        /// Dodanie wiersza do gridu
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataod"></param>
        /// <param name="datado"></param>
        /// <param name="iloscos"></param>
        /// <param name="parking"></param>
        /// <param name="jedzenie"></param>
        /// <param name="spa"></param>
        /// <param name="silownia"></param>
        /// <param name="imie"></param>
        /// <param name="nazwisko"></param>
        /// <param name="nrtel"></param>
        public void Populate(string id, string dataod, string datado, string iloscos, string parking, string jedzenie, string spa, string silownia, string imie, string nazwisko, string nrtel)
        {
            bool prk = false;
            bool fd = false;
            bool sil = false;
            bool sp = false;
            if (parking == "True")
            {
                //parking = "✅";
                prk = true;
            }
            if (jedzenie == "True")
            {
                jedzenie = "✅";
                fd = true;
            }
            if (spa == "True")
            {
                spa = "✅";
                sp = true;
            }
            if (silownia == "True")
            {
                //silownia = "✅";
                sil = true;
            }

            dg.Rows.Add(id, imie, nazwisko, nrtel, dataod, datado, iloscos, prk, fd, sp, sil);
        }

        /// <summary>
        /// Pobranie informacji z bazy danych i modyfikacja gridu
        /// </summary>
        public void Apped()
        {
            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"passwd.txt");
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
        /// <summary>
        /// Usuwanie wiersza z gridu
        /// </summary>
        /// <param name="id"></param>
        public void Delete(long id)
        {
            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();
            cnn = new MySqlConnection(connetionString);
            string sql = $"DELETE FROM `rezerwacja` WHERE ID='{id}'";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);

            try
            {
                cnn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.DeleteCommand = cnn.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;
                cmd.ExecuteNonQuery();

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }
        /// <summary>
        /// Aktualizacja wiersza w gridzie
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataod"></param>
        /// <param name="datado"></param>
        /// <param name="iloscos"></param>
        /// <param name="parking"></param>
        /// <param name="jedzenie"></param>
        /// <param name="spa"></param>
        /// <param name="silownia"></param>
        /// <param name="imie"></param>
        /// <param name="nazwisko"></param>
        /// <param name="nrtel"></param>
        public void Update(string id, string dataod, string datado, string iloscos, string parking, string jedzenie, string spa, string silownia, string imie, string nazwisko, string nrtel)
        {
            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();
            cnn = new MySqlConnection(connetionString);
            byte prk = 0;
            byte fd = 0;
            byte sp = 0;
            byte sil = 0;

            if (parking == "True")
            {
                prk = 1;
            }
            if (jedzenie == "True")
            {
                fd = 1;
            }
            if (spa == "True")
            {
                sp = 1;
            }
            if (silownia == "True")
            {
               sil  = 1;
            }


            string sql = $"UPDATE `rezerwacja` SET `id`='{id}',`dataod`='{dataod}',`datado`='{datado}',`iloscosob`='{iloscos}',`czyparking`='{prk}',`czyjedzenie`='{fd}',`czyspa`='{sp}',`czysilownia`='{sil}',`imie`='{imie}',`nazwisko`='{nazwisko}',`nrtelefonu`='{nrtel}' WHERE `id`='{id}'";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);

            try
            {
                cnn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.UpdateCommand = cnn.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                cmd.ExecuteNonQuery();

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }
        /// <summary>
        /// Dososowanie kolumnt w gridzie
        /// </summary>
        public Zaplanowane()
        {
            InitializeComponent();
            dg.ColumnCount = 7;
            dg.Columns[0].Name = "Numer rezerwacji";
            dg.Columns[1].Name = "Imie";
            dg.Columns[2].Name = "Nazwisko";
            dg.Columns[3].Name = "Numer telefonu";
            dg.Columns[4].Name = "Data od";
            dg.Columns[5].Name = "Data do";
            dg.Columns[6].Name = "Ilość osób";
            //dg.Columns[7].Name = "Parking";
            //dg.Columns[8].Name = "Wyżywienie";
            //dg.Columns[9].Name = "SPA";
            //dg.Columns[10].Name = "Siłownia";
            DataGridViewCheckBoxColumn parking = new DataGridViewCheckBoxColumn();
            parking.ValueType = typeof(bool);
            parking.HeaderText = "Parking";
            dg.Columns.Add(parking);
            DataGridViewCheckBoxColumn food = new DataGridViewCheckBoxColumn();
            food.ValueType = typeof(bool);
            food.HeaderText = "Wyżywienie";
            dg.Columns.Add(food);
            DataGridViewCheckBoxColumn spa = new DataGridViewCheckBoxColumn();
            spa.ValueType = typeof(bool);
            spa.HeaderText = "Spa";
            dg.Columns.Add(spa);
            DataGridViewCheckBoxColumn sil = new DataGridViewCheckBoxColumn();
            sil.ValueType = typeof(bool);
            sil.HeaderText = "Silownia";
            dg.Columns.Add(sil);
            dg.Columns[0].MinimumWidth = 70;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.Columns[0].ReadOnly = true;
            Apped();
        }
        /// <summary>
        /// Cofanie do poprzedniej karty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
        }
        /// <summary>
        /// Odswiezanie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dg.Rows.Clear();
            Apped();
        }
        /// <summary>
        /// Klik uruchamia usuwanie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            long selected = Int64.Parse(dg.SelectedRows[0].Cells[0].Value.ToString());
            Delete(selected);
            dg.Rows.Clear();
            Apped();
        }
        /// <summary>
        /// Uruchamianie aktualizacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            string selected = dg.SelectedRows[0].Cells[0].Value.ToString();
            string imie = dg.SelectedRows[0].Cells[1].Value.ToString();
            string nazwisko = dg.SelectedRows[0].Cells[2].Value.ToString();
            string numer = dg.SelectedRows[0].Cells[3].Value.ToString();
            string dataod = dg.SelectedRows[0].Cells[4].Value.ToString();
            string datado = dg.SelectedRows[0].Cells[5].Value.ToString();
            string ilos = dg.SelectedRows[0].Cells[6].Value.ToString();
            string parking = dg.SelectedRows[0].Cells[7].Value.ToString();
            string jedzenie = dg.SelectedRows[0].Cells[8].Value.ToString();
            string spa = dg.SelectedRows[0].Cells[9].Value.ToString();
            string silownia = dg.SelectedRows[0].Cells[10].Value.ToString();
            //Console.WriteLine(spa);
            Update(selected, dataod, datado, ilos, parking, jedzenie, spa, silownia, imie, nazwisko, numer);
            dg.Rows.Clear();
            Apped();
        }
    }
}

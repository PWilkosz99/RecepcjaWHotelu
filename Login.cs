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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {

            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"..\..\passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();
            cnn = new MySqlConnection(connetionString);
            try
            {
                label_conn.Visible = true;
                cnn.Open();
                Console.WriteLine("Connection Open !");
                MySqlCommand query = new MySqlCommand($"SELECT password FROM users where login = '{ULogin.Text}';", cnn);
                MySqlDataReader queryResult = query.ExecuteReader();
                bool x = queryResult.Read();
                if (x)
                {
                    string psw = queryResult.GetString(0);
                    cnn.Close();
                    label_conn.Visible = false;
                    if (UPassword.Text == psw)
                    {
                        if (!MW.Instance.PnlContainter.Controls.ContainsKey("Menu"))
                        {
                            Menu menu = new Menu();
                            menu.Dock = DockStyle.Fill;
                            MW.Instance.PnlContainter.Controls.Add(menu);
                        }
                        MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Wprowadzono błędne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {

                    MessageBox.Show("Wprowadzono błędne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd połączenia z bazą danych\n\n{ex.ToString()}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                label_conn.Visible = false;
                cnn.Close();
            }
        }
    }
}

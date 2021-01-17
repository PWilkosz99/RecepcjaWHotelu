using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
        /// <summary>
        /// Po nacisnięciu przyciusku metoda sprawdza czy dane są poprawne,
        /// jeśli tak przechodzi do menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_check_Click(object sender, EventArgs e)
        {

            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"passwd.txt");
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
                    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                    UTF8Encoding utf8 = new UTF8Encoding();
                    byte[] data = md5.ComputeHash(utf8.GetBytes(UPassword.Text));

                    string fpsw = Convert.ToBase64String(data);
                    string psw = queryResult.GetString(0);
                    //Console.WriteLine(fpsw);

                    queryResult.Close();
                    label_conn.Visible = false;
                    if (fpsw == psw)
                    {
                        MySqlCommand query2 = new MySqlCommand($"SELECT `counter` FROM `stats` WHERE `date` = '{DateTime.Now.ToShortDateString()}';", cnn);
                        MySqlDataReader query2Result = query2.ExecuteReader();
                        if (query2Result.Read())
                        {
                            MW.Counter = Int32.Parse(query2Result.GetString(0));
                            query2Result.Close();
                        }
                        else
                        {
                            query2Result.Close();
                            MW.Counter = 0;
                            MySqlCommand query3 = new MySqlCommand($"INSERT INTO `stats`(`date`, `counter`) VALUES ('{DateTime.Now.ToShortDateString()}','0');", cnn);
                            query3.ExecuteNonQuery();
                        }
                        cnn.Close();

                        if (!MW.Instance.PnlContainter.Controls.ContainsKey("Menu"))
                        {
                            Menu menu = new Menu();
                            menu.Dock = DockStyle.Fill;
                            MW.Instance.PnlContainter.Controls.Add(menu);
                        }
                        MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
                        ULogin.Text = "";
                        UPassword.Text = "";
                    }
                    else
                    {
                        cnn.Close();
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

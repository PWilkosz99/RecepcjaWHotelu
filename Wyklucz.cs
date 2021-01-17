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
    public partial class Wyklucz : UserControl
    {
        public Wyklucz()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Klik dodaje do bazy nowe wykluczenie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"..\..\passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open WKD!");
                MySqlCommand query = new MySqlCommand($"INSERT INTO `wykluczone`(`id`, `powod`) VALUES ('{cmb_pokoj.Text}','{txt_powod.Text}');", cnn);
                query.ExecuteNonQuery();
                cnn.Close();
            }            
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd połączenia z bazą danych\n\n{ex.ToString()}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }
            MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
        }
        /// <summary>
        /// Klik usuwa wykluczenie z bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {

            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"..\..\passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open WKU!");
                MySqlCommand query = new MySqlCommand($"DELETE FROM `wykluczone` WHERE `id`='{cmb_pokoj.Text}';", cnn);
                query.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd połączenia z bazą danych\n\n{ex.ToString()}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }
            MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
        }

        private void Wyklucz_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Klik powraca do menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
        }
    }
}

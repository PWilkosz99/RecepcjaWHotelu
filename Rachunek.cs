using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepcjaWHotelu
{
    /// <summary>
    /// Klasa obslugujaca rachunek
    /// </summary>
    class Rachunek
    {
        public string rezid;
        public int wielkosc;
        public bool czyuregulowano;
        public char metoda;
        /// <summary>
        /// Metoda dodaje informacje o statusie rachunku do bazy
        /// </summary>
        /// <returns></returns>
        public bool Ureguluj()
        {
            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open R1!");
                MySqlCommand query = new MySqlCommand($"INSERT INTO `rachunek` (`id`, `wielkosc`, `czyuregulowano`, `metoda`) VALUES ('{rezid}', '{wielkosc}', '1', '{metoda}');", cnn);
                query.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd połączenia z bazą danych\n\n{ex.ToString()}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                cnn.Close();
            }
            return false;
        }
    }
}

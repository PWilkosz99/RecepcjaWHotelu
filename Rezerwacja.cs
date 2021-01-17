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
    /// Klasa zajumjaca sie obsluga rezerwacji
    /// </summary>
    public class Rezerwacja
    {
        public long nrezerwacji;
        public int ilosob;
        public string dataod;
        public string datado;
        public bool czyrestauracja;
        public bool czysilownia;
        public bool czyparking;
        public bool czyspa;

        public string imie;
        public string nazwisko;
        public long nrtelefonu;
        /// <summary>
        /// Metoda dodajaca do bazy informacje o id, datach, ilosci osob oraz bazach dodatkowych
        /// </summary>
        /// <returns></returns>
        public bool Rezerwuj()
        {

            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();
            cnn = new MySqlConnection(connetionString);

            if ((MW.CurrentC == ""))
            {
                MW.CurrentC = "99999";
            }

            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open R1!");
                MySqlCommand query = new MySqlCommand($"SELECT `id` FROM `rezerwacja` where `id`='{nrezerwacji}';", cnn);
                MySqlDataReader queryResult = query.ExecuteReader();
                bool x = queryResult.Read();
                queryResult.Close();
                if (x)
                {
                    MessageBox.Show($"Rezerwacja o takim numerze znajduje się już w systemie", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cnn.Close();
                    return true;
                }
                else
                {
                    MySqlCommand query2 = new MySqlCommand($"INSERT INTO `rezerwacja` (`id`, `dataod`, `datado`, `iloscosob`, `czyparking`, `czyjedzenie`, `czyspa`, `czysilownia`, `imie`, `nazwisko`, `nrtelefonu`) VALUES ('{nrezerwacji}', '{dataod}', '{datado}', '{ilosob}', '{Convert.ToInt32(czyparking)}', '{Convert.ToInt32(czyrestauracja)}', '{Convert.ToInt32(czyspa)}', '{Convert.ToInt32(czysilownia)}', '', '', '');", cnn);
                    query2.ExecuteNonQuery();
                    cnn.Close();
                    return false;
                }
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
        /// <summary>
        /// Metoda dodaje dob bazy informacje o imieniu, nazwisku, numerze telefonu
        /// </summary>
        public void Rezerwuj2()
        {
            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open R2!");
                MySqlCommand query = new MySqlCommand($"UPDATE `rezerwacja` SET `imie`='{imie}',`nazwisko`='{nazwisko}',`nrtelefonu`='{nrtelefonu}' WHERE `id`='{MW.CurrentC}' ;", cnn);
                query.ExecuteNonQuery();
                MW.Counter++;
                MySqlCommand query2 = new MySqlCommand($"UPDATE `stats` SET `counter`='{MW.Counter}' WHERE `date` ='{DateTime.Now.ToShortDateString()}' ;", cnn);
                query2.ExecuteNonQuery();
                MW.CurrentC = "";
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
        }

        /// <summary>
        /// Metoda usuwajaca rezerwacje z bazy
        /// </summary>
        public void Odrezerwuj()
        {

            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open OD!");
                MySqlCommand query = new MySqlCommand($"DELETE FROM `rezerwacja` WHERE `id` = '{MW.CurrentC}';", cnn);
            query.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd połączenia z bazą danych\n\n{ex.ToString()}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                cnn.Close();
            }
        }
    }
}

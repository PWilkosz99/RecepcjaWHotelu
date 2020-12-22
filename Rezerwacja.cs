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
        public void Rezerwuj()
        {
            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"..\..\passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();
            cnn = new MySqlConnection(connetionString);

            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open R1!");
                MySqlCommand query = new MySqlCommand($"INSERT INTO `rezerwacja` (`id`, `dataod`, `datado`, `iloscosob`, `czyparking`, `czyjedzenie`, `czyspa`, `czysilownia`, `imie`, `nazwisko`, `nrtelefonu`) VALUES ('{nrezerwacji}', '{dataod}', '{datado}', '{ilosob}', '{Convert.ToInt32(czyparking)}', '{Convert.ToInt32(czyrestauracja)}', '{Convert.ToInt32(czyspa)}', '{Convert.ToInt32(czysilownia)}', '', '', '');", cnn);
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
        }
        public void Rezerwuj2()
        {
            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"..\..\passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open R2!");
                MySqlCommand query = new MySqlCommand($"UPDATE `rezerwacja` SET `imie`='{imie}',`nazwisko`='{nazwisko}',`nrtelefonu`='{nrtelefonu}' WHERE `id`={MW.CurrentC} ;", cnn);
                query.ExecuteNonQuery();
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
    }
}

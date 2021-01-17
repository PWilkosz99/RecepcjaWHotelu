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
    /// Klasa obslugujaca wykwaterowanie
    /// </summary>
    public class Wykwaterowanie
    {
        public long nr_rezerwacji;
        public int nr_pokoju;
        /// <summary>
        /// Metoda dokoknuje wykwaterowania uzytkownika z bazy
        /// </summary>
        /// <returns></returns>
        public byte Wykwateruj()
        {

            if (nr_rezerwacji != 0)
            {
                MySqlConnection cnn;
                StreamReader sr = File.OpenText(@"..\..\passwd.txt");
                string connetionString = sr.ReadLine();
                sr.Close();
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                Console.WriteLine("Connection Open WR!");
                MySqlCommand query = new MySqlCommand($"SELECT `nrezerwacji` FROM `zakwaterowanie` WHERE `nrezerwacji`= '{nr_rezerwacji}';", cnn);
                MySqlDataReader queryResult = query.ExecuteReader();
                bool x = queryResult.Read();
                queryResult.Close();
                if (x)
                {
                    MySqlCommand query2 = new MySqlCommand($"DELETE FROM `zakwaterowanie` WHERE `nrezerwacji` = '{nr_rezerwacji}';", cnn);
                    query2.ExecuteNonQuery();
                    MySqlCommand query3 = new MySqlCommand($"SELECT `czyuregulowano` FROM `rachunek` WHERE `id` = '{nr_rezerwacji}';", cnn);
                    MySqlDataReader query3Result = query3.ExecuteReader();
                    bool z = query3Result.Read();
                    if (z)
                    {
                        string pay = query3Result.GetString(0);
                        if (pay == "True")
                        {
                            cnn.Close();
                            return 1;
                        }
                    }
                    return 0;
                }
                else
                {
                    MessageBox.Show($"Brak rezerwacji o podanym numerze", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 3;
                }
            }
            else if (nr_pokoju !=0)
            {
                MySqlConnection cnn;
                StreamReader sr = File.OpenText(@"..\..\passwd.txt");
                string connetionString = sr.ReadLine();
                sr.Close();
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                Console.WriteLine("Connection Open WP!");
                MySqlCommand query = new MySqlCommand($"SELECT `npokoju` FROM `zakwaterowanie` WHERE `npokoju`= '{nr_pokoju}';", cnn);
                MySqlDataReader queryResult = query.ExecuteReader();
                bool x = queryResult.Read();
                queryResult.Close();
                if (x)
                {
                    MySqlCommand query4 = new MySqlCommand($"SELECT `nrezerwacji` FROM `zakwaterowanie` WHERE `npokoju`= '{nr_pokoju}';", cnn);
                    MySqlDataReader query4Result = query4.ExecuteReader();
                    bool j = query4Result.Read();
                    nr_rezerwacji = Int64.Parse(query4Result.GetString(0));
                    Console.WriteLine(nr_rezerwacji);
                    query4Result.Close();
                    MySqlCommand query2 = new MySqlCommand($"DELETE FROM `zakwaterowanie` WHERE `npokoju` = '{nr_pokoju}';", cnn);
                    query2.ExecuteNonQuery();
                    MySqlCommand query3 = new MySqlCommand($"SELECT `czyuregulowano` FROM `rachunek` WHERE `id` = '{nr_rezerwacji}';", cnn);
                    MySqlDataReader query3Result = query3.ExecuteReader();
                    bool z = query3Result.Read();
                    if (z)
                    {
                        string pay = query3Result.GetString(0);
                        Console.WriteLine(pay);
                        if (pay == "True")
                        {
                            cnn.Close();
                            return 1;
                        }
                    }
                    cnn.Close();
                    return 0;
                }
                else
                {
                    MessageBox.Show($"Brak rezerwacji o podanym numerze pokoju", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 3;
                }
            }
            else
            {
                MessageBox.Show($"Proszę wpisać numer rezerwacji lub numer pokoju", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 3;
            }
        }
    }
}
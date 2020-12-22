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
    class Zakwaterowanie
    {
        public long nr_rezerwacji;
        public int nr_pokoju;
        public bool Zakwateruj()
        {
            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"..\..\passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();
            cnn = new MySqlConnection(connetionString);



            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open Z!");
                MySqlCommand query = new MySqlCommand($"SELECT `id` FROM `rezerwacja` WHERE `id`={nr_rezerwacji}", cnn);
                MySqlDataReader queryResult = query.ExecuteReader();
                bool x = queryResult.Read();
                Console.WriteLine();
                if (x)
                {
                    long dbc = Int64.Parse(queryResult.GetString(0));
                    cnn.Close();
                    if (nr_rezerwacji == dbc)
                    {
                        cnn.Open();
                        MySqlCommand query2 = new MySqlCommand($"INSERT INTO `zakwaterowanie`(`nrezerwacji`, `npokoju`) VALUES ({nr_rezerwacji},{nr_pokoju});", cnn);
                        query2.ExecuteNonQuery();
                        cnn.Close();
                        return true;
                    }
                    return false;
                }
                else
                {
                     MessageBox.Show($"Brak rezerwacji o podanym numerze", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

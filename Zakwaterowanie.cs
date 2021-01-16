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
    public class Zakwaterowanie
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
                if (x)
                {
                    long dbc = Int64.Parse(queryResult.GetString(0));
                    queryResult.Close(); ;
                    if (nr_rezerwacji == dbc)
                    {
                        MySqlCommand query3 = new MySqlCommand($"SELECT `nrezerwacji` FROM `zakwaterowanie` where `nrezerwacji`='{nr_rezerwacji}';", cnn);
                        MySqlDataReader query3Result = query3.ExecuteReader();
                        bool z = query3Result.Read();
                        query3Result.Close();
                        if (z)
                        {
                            MessageBox.Show($"Klient o takim numerze rezerwacji zostal juz zakwaterowany", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cnn.Close();
                            return false;
                        }
                        else
                        {
                            MySqlCommand qa = new MySqlCommand($"SELECT `id` FROM `wykluczone` WHERE `id` = '{nr_pokoju}'; ", cnn);
                            MySqlDataReader qar = qa.ExecuteReader();
                            bool avl = qar.Read();
                            qar.Close();
                            if (avl)
                            {
                                MessageBox.Show($"Pokój o podanym numerze jest wykluczony z użytku", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }
                            else
                            {
                                MySqlCommand query2 = new MySqlCommand($"INSERT INTO `zakwaterowanie`(`nrezerwacji`, `npokoju`) VALUES ({nr_rezerwacji},{nr_pokoju});", cnn);
                                query2.ExecuteNonQuery();
                                cnn.Close();
                                return true;
                            }
                        }
                    }
                    cnn.Close();
                    return false;
                }
                else
                {
                    MessageBox.Show($"Brak rezerwacji o podanym numerze", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

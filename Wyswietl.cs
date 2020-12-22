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
    public partial class Wyswietl : UserControl
    {
        public Wyswietl()
        {
            InitializeComponent();
            Wyswietlanie();
        }

        public void Wyswietlanie()
        {
            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"..\..\passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open W!");
                MySqlCommand q1 = new MySqlCommand($"SELECT `npokoju` FROM `zakwaterowanie` WHERE `npokoju`='1';", cnn);
                MySqlDataReader qr1 = q1.ExecuteReader();
                if (qr1.Read())
                {
                    qr1.Close();
                    MySqlCommand r1 = new MySqlCommand($"SELECT `datado` FROM `rezerwacja` WHERE `id`=(SELECT `nrezerwacji` FROM `zakwaterowanie` WHERE `npokoju`='1');", cnn);
                    MySqlDataReader rr1 = r1.ExecuteReader();
                    rr1.Read();
                    s1.Text = "ZAJĘTY";
                    t1.Text = $"DO {rr1.GetString(0)}";
                    rr1.Close();
                    s1.ForeColor = Color.Red;
                }
                else
                {
                    qr1.Close();
                    MySqlCommand ex1 = new MySqlCommand($"SELECT `id` FROM `wykluczone` WHERE `id` = '1';", cnn);
                    MySqlDataReader exr1 = ex1.ExecuteReader();
                    if (exr1.Read())
                    {
                        exr1.Close();
                        s1.Text = "WYKLUCZONY";
                        s1.ForeColor = Color.Orange;
                        MySqlCommand r1 = new MySqlCommand($"SELECT `powod` FROM `wykluczone` WHERE `id` = '1';", cnn);
                        MySqlDataReader rr1 = r1.ExecuteReader();
                        rr1.Read();
                        t1.Text = rr1.GetString(0);
                        rr1.Close();
                    }
                    else
                    {
                        exr1.Close();
                        s1.Text = "WOLNY";
                        s1.ForeColor = Color.Green;
                        t1.Text = "-";
                    }
                }
                MySqlCommand q2 = new MySqlCommand($"SELECT `npokoju` FROM `zakwaterowanie` WHERE `npokoju`='2';", cnn);
                MySqlDataReader qr2 = q2.ExecuteReader();
                if (qr2.Read())
                {
                    qr2.Close();
                    MySqlCommand r2 = new MySqlCommand($"SELECT `datado` FROM `rezerwacja` WHERE `id`=(SELECT `nrezerwacji` FROM `zakwaterowanie` WHERE `npokoju`='2');", cnn);
                    MySqlDataReader rr2 = r2.ExecuteReader();
                    rr2.Read();
                    s2.Text = "ZAJĘTY";
                    t2.Text = $"DO {rr2.GetString(0)}";
                    rr2.Close();
                    s2.ForeColor = Color.Red;
                }
                else
                {
                    qr2.Close();
                    MySqlCommand ex2 = new MySqlCommand($"SELECT `id` FROM `wykluczone` WHERE `id` = '2';", cnn);
                    MySqlDataReader exr2 = ex2.ExecuteReader();
                    if (exr2.Read())
                    {
                        exr2.Close();
                        s2.Text = "WYKLUCZONY";
                        s2.ForeColor = Color.Orange;
                        MySqlCommand r2 = new MySqlCommand($"SELECT `powod` FROM `wykluczone` WHERE `id` = '2';", cnn);
                        MySqlDataReader rr2 = r2.ExecuteReader();
                        rr2.Read();
                        t2.Text = rr2.GetString(0);
                        rr2.Close();
                    }
                    else
                    {
                        exr2.Close();
                        s2.Text = "WOLNY";
                        s2.ForeColor = Color.Green;
                        t2.Text = "-";
                    }
                }
                MySqlCommand q3 = new MySqlCommand($"SELECT `npokoju` FROM `zakwaterowanie` WHERE `npokoju`='3';", cnn);
                MySqlDataReader qr3 = q3.ExecuteReader();
                if (qr3.Read())
                {
                    qr3.Close();
                    MySqlCommand r3 = new MySqlCommand($"SELECT `datado` FROM `rezerwacja` WHERE `id`=(SELECT `nrezerwacji` FROM `zakwaterowanie` WHERE `npokoju`='3');", cnn);
                    MySqlDataReader rr3 = r3.ExecuteReader();
                    rr3.Read();
                    s3.Text = "ZAJĘTY";
                    t3.Text = $"DO {rr3.GetString(0)}";
                    rr3.Close();
                    s3.ForeColor = Color.Red;
                }
                else
                {
                    qr3.Close();
                    MySqlCommand ex3 = new MySqlCommand($"SELECT `id` FROM `wykluczone` WHERE `id` = '3';", cnn);
                    MySqlDataReader exr3 = ex3.ExecuteReader();
                    if (exr3.Read())
                    {
                        exr3.Close();
                        s3.Text = "WYKLUCZONY";
                        s3.ForeColor = Color.Orange;
                        MySqlCommand r3 = new MySqlCommand($"SELECT `powod` FROM `wykluczone` WHERE `id` = '3';", cnn);
                        MySqlDataReader rr3 = r3.ExecuteReader();
                        rr3.Read();
                        t3.Text = rr3.GetString(0);
                        rr3.Close();
                    }
                    else
                    {
                        exr3.Close();
                        s3.Text = "WOLNY";
                        s3.ForeColor = Color.Green;
                        t3.Text = "-";
                    }
                }
                MySqlCommand q4 = new MySqlCommand($"SELECT `npokoju` FROM `zakwaterowanie` WHERE `npokoju`='4';", cnn);
                MySqlDataReader qr4 = q4.ExecuteReader();
                if (qr4.Read())
                {
                    qr4.Close();
                    MySqlCommand r4 = new MySqlCommand($"SELECT `datado` FROM `rezerwacja` WHERE `id`=(SELECT `nrezerwacji` FROM `zakwaterowanie` WHERE `npokoju`='4');", cnn);
                    MySqlDataReader rr4 = r4.ExecuteReader();
                    rr4.Read();
                    s4.Text = "ZAJĘTY";
                    t4.Text = $"DO {rr4.GetString(0)}";
                    rr4.Close();
                    s4.ForeColor = Color.Red;
                }
                else
                {
                    qr4.Close();
                    MySqlCommand ex4 = new MySqlCommand($"SELECT `id` FROM `wykluczone` WHERE `id` = '4';", cnn);
                    MySqlDataReader exr4 = ex4.ExecuteReader();
                    if (exr4.Read())
                    {
                        exr4.Close();
                        s4.Text = "WYKLUCZONY";
                        s4.ForeColor = Color.Orange;
                        MySqlCommand r4 = new MySqlCommand($"SELECT `powod` FROM `wykluczone` WHERE `id` = '4';", cnn);
                        MySqlDataReader rr4 = r4.ExecuteReader();
                        rr4.Read();
                        t4.Text = rr4.GetString(0);
                        rr4.Close();
                    }
                    else
                    {
                        exr4.Close();
                        s4.Text = "WOLNY";
                        s4.ForeColor = Color.Green;
                        t4.Text = "-";
                    }
                }
                MySqlCommand q5 = new MySqlCommand($"SELECT `npokoju` FROM `zakwaterowanie` WHERE `npokoju`='5';", cnn);
                MySqlDataReader qr5 = q5.ExecuteReader();
                if (qr5.Read())
                {
                    qr5.Close();
                    MySqlCommand r5 = new MySqlCommand($"SELECT `datado` FROM `rezerwacja` WHERE `id`=(SELECT `nrezerwacji` FROM `zakwaterowanie` WHERE `npokoju`='5');", cnn);
                    MySqlDataReader rr5 = r5.ExecuteReader();
                    rr5.Read();
                    s5.Text = "ZAJĘTY";
                    t5.Text = $"DO {rr5.GetString(0)}";
                    rr5.Close();
                    s5.ForeColor = Color.Red;
                }
                else
                {
                    qr5.Close();
                    MySqlCommand ex5 = new MySqlCommand($"SELECT `id` FROM `wykluczone` WHERE `id` = '5';", cnn);
                    MySqlDataReader exr5 = ex5.ExecuteReader();
                    if (exr5.Read())
                    {
                        exr5.Close();
                        s5.Text = "WYKLUCZONY";
                        s5.ForeColor = Color.Orange;
                        MySqlCommand r5 = new MySqlCommand($"SELECT `powod` FROM `wykluczone` WHERE `id` = '5';", cnn);
                        MySqlDataReader rr5 = r5.ExecuteReader();
                        rr5.Read();
                        t5.Text = rr5.GetString(0);
                        rr5.Close();
                    }
                    else
                    {
                        exr5.Close();
                        s5.Text = "WOLNY";
                        s5.ForeColor = Color.Green;
                        t5.Text = "-";
                    }
                }
                MySqlCommand q6 = new MySqlCommand($"SELECT `npokoju` FROM `zakwaterowanie` WHERE `npokoju`='6';", cnn);
                MySqlDataReader qr6 = q6.ExecuteReader();
                if (qr6.Read())
                {
                    qr6.Close();
                    MySqlCommand r6 = new MySqlCommand($"SELECT `datado` FROM `rezerwacja` WHERE `id`=(SELECT `nrezerwacji` FROM `zakwaterowanie` WHERE `npokoju`='6');", cnn);
                    MySqlDataReader rr6 = r6.ExecuteReader();
                    rr6.Read();
                    s6.Text = "ZAJĘTY";
                    t6.Text = $"DO {rr6.GetString(0)}";
                    rr6.Close();
                    s6.ForeColor = Color.Red;
                }
                else
                {
                    qr6.Close();
                    MySqlCommand ex6 = new MySqlCommand($"SELECT `id` FROM `wykluczone` WHERE `id` = '6';", cnn);
                    MySqlDataReader exr6 = ex6.ExecuteReader();
                    if (exr6.Read())
                    {
                        exr6.Close();
                        s6.Text = "WYKLUCZONY";
                        s6.ForeColor = Color.Orange;
                        MySqlCommand r6 = new MySqlCommand($"SELECT `powod` FROM `wykluczone` WHERE `id` = '6';", cnn);
                        MySqlDataReader rr6 = r6.ExecuteReader();
                        rr6.Read();
                        t6.Text = rr6.GetString(0);
                        rr6.Close();
                    }
                    else
                    {
                        exr6.Close();
                        s6.Text = "WOLNY";
                        s6.ForeColor = Color.Green;
                        t6.Text = "-";
                    }
                }
                MySqlCommand q7 = new MySqlCommand($"SELECT `npokoju` FROM `zakwaterowanie` WHERE `npokoju`='7';", cnn);
                MySqlDataReader qr7 = q7.ExecuteReader();
                if (qr7.Read())
                {
                    qr7.Close();
                    MySqlCommand r7 = new MySqlCommand($"SELECT `datado` FROM `rezerwacja` WHERE `id`=(SELECT `nrezerwacji` FROM `zakwaterowanie` WHERE `npokoju`='7');", cnn);
                    MySqlDataReader rr7 = r7.ExecuteReader();
                    rr7.Read();
                    s7.Text = "ZAJĘTY";
                    t7.Text = $"DO {rr7.GetString(0)}";
                    rr7.Close();
                    s7.ForeColor = Color.Red;
                }
                else
                {
                    qr7.Close();
                    MySqlCommand ex7 = new MySqlCommand($"SELECT `id` FROM `wykluczone` WHERE `id` = '7';", cnn);
                    MySqlDataReader exr7 = ex7.ExecuteReader();
                    if (exr7.Read())
                    {
                        exr7.Close();
                        s7.Text = "WYKLUCZONY";
                        s7.ForeColor = Color.Orange;
                        MySqlCommand r7 = new MySqlCommand($"SELECT `powod` FROM `wykluczone` WHERE `id` = '7';", cnn);
                        MySqlDataReader rr7 = r7.ExecuteReader();
                        rr7.Read();
                        t7.Text = rr7.GetString(0);
                        rr7.Close();
                    }
                    else
                    {
                        exr7.Close();
                        s7.Text = "WOLNY";
                        s7.ForeColor = Color.Green;
                        t7.Text = "-";
                    }
                }
                MySqlCommand q8 = new MySqlCommand($"SELECT `npokoju` FROM `zakwaterowanie` WHERE `npokoju`='8';", cnn);
                MySqlDataReader qr8 = q8.ExecuteReader();
                if (qr8.Read())
                {
                    qr8.Close();
                    MySqlCommand r8 = new MySqlCommand($"SELECT `datado` FROM `rezerwacja` WHERE `id`=(SELECT `nrezerwacji` FROM `zakwaterowanie` WHERE `npokoju`='8');", cnn);
                    MySqlDataReader rr8 = r8.ExecuteReader();
                    rr8.Read();
                    s8.Text = "ZAJĘTY";
                    t8.Text = $"DO {rr8.GetString(0)}";
                    rr8.Close();
                    s8.ForeColor = Color.Red;
                }
                else
                {
                    qr8.Close();
                    MySqlCommand ex8 = new MySqlCommand($"SELECT `id` FROM `wykluczone` WHERE `id` = '8';", cnn);
                    MySqlDataReader exr8 = ex8.ExecuteReader();
                    if (exr8.Read())
                    {
                        exr8.Close();
                        s8.Text = "WYKLUCZONY";
                        s8.ForeColor = Color.Orange;
                        MySqlCommand r8 = new MySqlCommand($"SELECT `powod` FROM `wykluczone` WHERE `id` = '8';", cnn);
                        MySqlDataReader rr8 = r8.ExecuteReader();
                        rr8.Read();
                        t8.Text = rr8.GetString(0);
                        rr8.Close();
                    }
                    else
                    {
                        exr8.Close();
                        s8.Text = "WOLNY";
                        s8.ForeColor = Color.Green;
                        t8.Text = "-";
                    }
                }
                MySqlCommand q9 = new MySqlCommand($"SELECT `npokoju` FROM `zakwaterowanie` WHERE `npokoju`='9';", cnn);
                MySqlDataReader qr9 = q9.ExecuteReader();
                if (qr9.Read())
                {
                    qr9.Close();
                    MySqlCommand r9 = new MySqlCommand($"SELECT `datado` FROM `rezerwacja` WHERE `id`=(SELECT `nrezerwacji` FROM `zakwaterowanie` WHERE `npokoju`='9');", cnn);
                    MySqlDataReader rr9 = r9.ExecuteReader();
                    rr9.Read();
                    s9.Text = "ZAJĘTY";
                    t9.Text = $"DO {rr9.GetString(0)}";
                    rr9.Close();
                    s9.ForeColor = Color.Red;
                }
                else
                {
                    qr9.Close();
                    MySqlCommand ex9 = new MySqlCommand($"SELECT `id` FROM `wykluczone` WHERE `id` = '9';", cnn);
                    MySqlDataReader exr9 = ex9.ExecuteReader();
                    if (exr9.Read())
                    {
                        exr9.Close();
                        s9.Text = "WYKLUCZONY";
                        s9.ForeColor = Color.Orange;
                        MySqlCommand r9 = new MySqlCommand($"SELECT `powod` FROM `wykluczone` WHERE `id` = '9';", cnn);
                        MySqlDataReader rr9 = r9.ExecuteReader();
                        rr9.Read();
                        t9.Text = rr9.GetString(0);
                        rr9.Close();
                    }
                    else
                    {
                        exr9.Close();
                        s9.Text = "WOLNY";
                        s9.ForeColor = Color.Green;
                        t9.Text = "-";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd połączenia z bazą danych\n\n{ex.ToString()}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Wyswietlanie();
        }
    }
}

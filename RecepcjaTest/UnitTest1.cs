using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RecepcjaWHotelu;
using MySql.Data.MySqlClient;
using System.IO;


namespace RecepcjaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PrzypadekStd1()
        {

            Rezerwacja rt = new Rezerwacja();
            rt.czyparking = true;
            rt.czyrestauracja = true;
            rt.czysilownia = true;
            rt.czyspa = true;
            rt.datado = "16.02.2021";
            rt.dataod = "16.01.2021";
            rt.ilosob = 5;
            rt.nrezerwacji = 99999;
            rt.imie = "ABC";
            rt.nazwisko = "DEF";
            rt.nrtelefonu = 999999999;
            MW.CurrentC = "99999";
            rt.Rezerwuj();
            rt.Rezerwuj2();


            Zakwaterowanie zt = new Zakwaterowanie();
            zt.nr_pokoju = 10;
            zt.nr_rezerwacji = rt.nrezerwacji;
            zt.Zakwateruj();

            Wykwaterowanie wt = new Wykwaterowanie();
            wt.nr_pokoju = zt.nr_pokoju;
            wt.nr_rezerwacji = rt.nrezerwacji;

            byte c = wt.Wykwateruj();

            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            MySqlCommand query = new MySqlCommand($"DELETE FROM `rezerwacja` WHERE `rezerwacja`.`id` = 99999", cnn);
            query.ExecuteNonQuery();
            cnn.Close();

           Assert.AreEqual(0 ,c);
        }

        [TestMethod]
        public void PrzypadekStd2()
        {

            Rezerwacja rt = new Rezerwacja();
            rt.czyparking = false;
            rt.czyrestauracja = true;
            rt.czysilownia = false;
            rt.czyspa = true;
            rt.datado = "25.06.2021";
            rt.dataod = "16.07.2021";
            rt.ilosob = 1;
            rt.nrezerwacji = 99999;
            rt.imie = "CBA";
            rt.nazwisko = "FED";
            rt.nrtelefonu = 123456789;
            MW.CurrentC = "99999";
            rt.Rezerwuj();
            rt.Rezerwuj2();


            Zakwaterowanie zt = new Zakwaterowanie();
            zt.nr_pokoju = 5;
            zt.nr_rezerwacji = rt.nrezerwacji;
            zt.Zakwateruj();

            Wykwaterowanie wt = new Wykwaterowanie();
            wt.nr_pokoju = zt.nr_pokoju;
            wt.nr_rezerwacji = rt.nrezerwacji;

            byte c = wt.Wykwateruj();

            MySqlConnection cnn;
            StreamReader sr = File.OpenText(@"passwd.txt");
            string connetionString = sr.ReadLine();
            sr.Close();
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            MySqlCommand query = new MySqlCommand($"DELETE FROM `rezerwacja` WHERE `rezerwacja`.`id` = 99999", cnn);
            query.ExecuteNonQuery();
            cnn.Close();

            Assert.AreEqual(0, c);
        }

        [TestMethod]
        public void BrakRezerwacji()
        {
            Wykwaterowanie wt = new Wykwaterowanie();
            wt.nr_rezerwacji = 99999;

            byte c = wt.Wykwateruj();

            Assert.AreEqual(3, c);
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepcjaWHotelu
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Klikniecie przenosi do rezerwacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_rezerwuj_Click(object sender, EventArgs e)
        {
            if (!MW.Instance.PnlContainter.Controls.ContainsKey("Rezerwuj"))
            {
                Rezerwuj rezerwuj = new Rezerwuj();
                rezerwuj.Dock = DockStyle.Fill;
                MW.Instance.PnlContainter.Controls.Add(rezerwuj);
            }
            MW.Instance.PnlContainter.Controls["Rezerwuj"].BringToFront();
        }
        /// <summary>
        /// Klikniecie przenos do zakwaterowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_zakwateruj_Click(object sender, EventArgs e)
        {
            if (!MW.Instance.PnlContainter.Controls.ContainsKey("Zakwateruj"))
            {
                Zakwateruj zakwateruj = new Zakwateruj();
                zakwateruj.Dock = DockStyle.Fill;
                MW.Instance.PnlContainter.Controls.Add(zakwateruj);
            }
            MW.Instance.PnlContainter.Controls["Zakwateruj"].BringToFront();
        }
        /// <summary>
        /// Klikniecie przenosi do wykwaterowia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_wykwateruj_Click(object sender, EventArgs e)
        {
            if (!MW.Instance.PnlContainter.Controls.ContainsKey("Wykwateruj"))
            {
                Wykwateruj wykwateruj = new Wykwateruj();
                wykwateruj.Dock = DockStyle.Fill;
                MW.Instance.PnlContainter.Controls.Add(wykwateruj);
            }
            MW.Instance.PnlContainter.Controls["Wykwateruj"].BringToFront();
        }
        /// <summary>
        /// Klikniecie przenosi do wyswietlania zakwaterowan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_wyswietl_Click(object sender, EventArgs e)
        {
            if (!MW.Instance.PnlContainter.Controls.ContainsKey("Wyswietl"))
            {
                Wyswietl wyswietlanie = new Wyswietl();
                wyswietlanie.Dock = DockStyle.Fill;
                MW.Instance.PnlContainter.Controls.Add(wyswietlanie);
            }
            MW.Instance.PnlContainter.Controls["Wyswietl"].BringToFront();
        }
        /// <summary>
        /// Klikniecie przenosi do planowania wyklczen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_wyklucz_Click(object sender, EventArgs e)
        {
            if (!MW.Instance.PnlContainter.Controls.ContainsKey("Wyklucz"))
            {
                Wyklucz wyklucz = new Wyklucz();
                wyklucz.Dock = DockStyle.Fill;
                MW.Instance.PnlContainter.Controls.Add(wyklucz);
            }
            MW.Instance.PnlContainter.Controls["Wyklucz"].BringToFront();
        }
        /// <summary>
        /// Klikniecie przenosi do wyswietlania wyklczen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_zaplanowane_Click(object sender, EventArgs e)
        {
            if (!MW.Instance.PnlContainter.Controls.ContainsKey("Zaplanowane"))
            {
                Zaplanowane zaplanowane = new Zaplanowane();
                zaplanowane.Dock = DockStyle.Fill;
                MW.Instance.PnlContainter.Controls.Add(zaplanowane);
            }
            MW.Instance.PnlContainter.Controls["Zaplanowane"].BringToFront();
        }
        /// <summary>
        /// Klikniecie wylogowuje uzytkownika i przenosi do strony logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_logout_Click(object sender, EventArgs e)
        {
            MW.Instance.PnlContainter.Controls["Login"].BringToFront();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}

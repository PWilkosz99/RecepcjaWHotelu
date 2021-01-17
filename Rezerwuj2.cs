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
    public partial class Rezerwuj2 : UserControl
    {
        public Rezerwuj2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Klik dodaje do bazy o imieniu, nazwisku, nrtelefunu klienta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_potwierdz_Click(object sender, EventArgs e)
        {
            if(!(txt_imie.Text == "") && !(txt_nazwisko.Text == "") && !(txt_numer.Text == "")){
                var rezerwacja2 = new Rezerwacja();
                rezerwacja2.imie = txt_imie.Text;
                rezerwacja2.nazwisko = txt_nazwisko.Text;
                rezerwacja2.nrtelefonu = Int64.Parse(txt_numer.Text);
                rezerwacja2.Rezerwuj2();
                MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
                txt_imie.Text = "";
                txt_nazwisko.Text = "";
                txt_numer.Text = "";
            }
            else
            {
                MessageBox.Show("Uzupełnij pozostałe dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Klik powraca do poprzedniej karty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            var rezerwacja2 = new Rezerwacja();
            rezerwacja2.Odrezerwuj();
            MW.Instance.PnlContainter.Controls["Rezerwuj"].BringToFront();
        }
    }
}

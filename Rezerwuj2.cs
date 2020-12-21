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

        private void btn_potwierdz_Click(object sender, EventArgs e)
        {
            var rezerwacja2 = new Rezerwacja();
            rezerwacja2.imie = txt_imie.Text;
            rezerwacja2.nazwisko = txt_nazwisko.Text;
            rezerwacja2.nrtelefonu = Int64.Parse(txt_numer.Text);
            rezerwacja2.Rezerwuj2();
            MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
        }
    }
}

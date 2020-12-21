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
    public partial class Zakwateruj : UserControl
    {
        public Zakwateruj()
        {
            InitializeComponent();
        }

        private void btn_potwierdz_Click(object sender, EventArgs e)
        {
            string imie = txt_imie.Text;
            string nazwisko = txt_nazwisko.Text;
            string numer = txt_numer.Text;
            System.DateTime date1 = dt1.Value;
            System.DateTime date2 = dt2.Value;
            if (!MW.Instance.PnlContainter.Controls.ContainsKey("Zakwateruj2"))
            {
                Zakwateruj2 zakwateruj2 = new Zakwateruj2();
                zakwateruj2.Dock = DockStyle.Fill;
                MW.Instance.PnlContainter.Controls.Add(zakwateruj2);
            }
            MW.Instance.PnlContainter.Controls["Zakwateruj2"].BringToFront();


        }
    }
}

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
            Zakwaterowanie zakwaterowanie = new Zakwaterowanie();
            if(txt_nrrez.Text!="")
                zakwaterowanie.nr_rezerwacji = Int64.Parse(txt_nrrez.Text);
            if (bx_nrpokoju.Text != "")
                zakwaterowanie.nr_pokoju = Int32.Parse(bx_nrpokoju.Text); 
            bool nxtst = zakwaterowanie.Zakwateruj();

            if (rd_teraz.Checked)
            {
                if (!MW.Instance.PnlContainter.Controls.ContainsKey("Platnosc"))
                {
                    Platnosc platnosc = new Platnosc();
                    platnosc.Dock = DockStyle.Fill;
                    MW.Instance.PnlContainter.Controls.Add(platnosc);
                }
                if(nxtst)
                    MW.Instance.PnlContainter.Controls["Platnosc"].BringToFront();
                MW.CurrentC = txt_nrrez.Text;
            }
            else if (rd_pozniej.Checked)
            {
                if(nxtst)
                    MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
            }
            else
            {
                MessageBox.Show("Proszę wybrać rodzaj płatności", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

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
    public partial class Wykwateruj : UserControl
    {
        public Wykwateruj()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Wykwaterowanie wykwaterowanie = new Wykwaterowanie();
            if(cmb_numerpokoju.Text!="")
                wykwaterowanie.nr_pokoju = Int32.Parse(cmb_numerpokoju.Text);
            if(txt_nrrezerwacji.Text!="")
                wykwaterowanie.nr_rezerwacji = Int64.Parse(txt_nrrezerwacji.Text);
            //bool status = wykwaterowanie.Wykwateruj();
            byte c = wykwaterowanie.Wykwateruj();
            if (c==1)
            {
                MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
            }
            else if(c==0)
            {
                if (!MW.Instance.PnlContainter.Controls.ContainsKey("Platnosc"))
                {
                    Platnosc platnosc = new Platnosc();
                    platnosc.Dock = DockStyle.Fill;
                    MW.Instance.PnlContainter.Controls.Add(platnosc);
                }
                    MW.Instance.PnlContainter.Controls["Platnosc"].BringToFront();
            }

        }

        private void txt_nrrezerwacji_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

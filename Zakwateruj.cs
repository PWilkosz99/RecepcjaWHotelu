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

            if(txt_nrrez.Text != "" && bx_nrpokoju.Text != "")
            {
                Zakwaterowanie zakwaterowanie = new Zakwaterowanie();
                zakwaterowanie.nr_rezerwacji = Int64.Parse(txt_nrrez.Text);
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
                    if (nxtst)
                    {
                        MW.Instance.PnlContainter.Controls["Platnosc"].BringToFront();
                        MW.CurrentC = txt_nrrez.Text;
                        txt_nrrez.Text = "";
                        bx_nrpokoju.SelectedIndex = 0;
                    }
                    
                }
                else if (rd_pozniej.Checked)
                {
                    if (nxtst)
                    {
                        MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
                        txt_nrrez.Text = "";
                        bx_nrpokoju.SelectedIndex = 0;
                    }    
                }
                else
                {
                    MessageBox.Show("Proszę wybrać rodzaj płatności", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Proszę uzupełnić pozostałe dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txt_nrrez_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
        }
    }
}

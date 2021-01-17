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
        /// <summary>
        /// Klik dokonuje wykwaterowania uzytkownika z bazy
        /// oraz w zaleznosci od statusu platnosci
        /// przenosi do odpowiedniej karty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (!(cmb_numerpokoju.Text == "" && txt_nrrezerwacji.Text == ""))
            {
                Wykwaterowanie wykwaterowanie = new Wykwaterowanie();
                if (cmb_numerpokoju.Text != "")
                    wykwaterowanie.nr_pokoju = Int32.Parse(cmb_numerpokoju.Text);
                if (txt_nrrezerwacji.Text != "")
                    wykwaterowanie.nr_rezerwacji = Int64.Parse(txt_nrrezerwacji.Text);
                //bool status = wykwaterowanie.Wykwateruj();
                byte c = wykwaterowanie.Wykwateruj();
                if (c == 1)
                {
                    MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
                    //cmb_numerpokoju.SelectedIndex = 0;
                    //txt_nrrezerwacji.Text = "";
                }
                else if (c == 0)
                {
                    if (!MW.Instance.PnlContainter.Controls.ContainsKey("Platnosc"))
                    {
                        Platnosc platnosc = new Platnosc();
                        platnosc.Dock = DockStyle.Fill;
                        MW.Instance.PnlContainter.Controls.Add(platnosc);
                    }
                    MW.Instance.PnlContainter.Controls["Platnosc"].BringToFront();
                    //cmb_numerpokoju.SelectedIndex = 0;
                    //txt_nrrezerwacji.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Blokada wpisywania znakow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_nrrezerwacji_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        /// <summary>
        /// Powrot do poprzedniej karty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
        }
    }
}

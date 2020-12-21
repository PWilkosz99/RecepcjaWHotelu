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
    public partial class Zakwateruj2 : UserControl
    {
        public Zakwateruj2()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (rd_teraz.Checked)
            {
                if (!MW.Instance.PnlContainter.Controls.ContainsKey("Platnosc"))
                {
                    Platnosc platnosc = new Platnosc();
                    platnosc.Dock = DockStyle.Fill;
                    MW.Instance.PnlContainter.Controls.Add(platnosc);
                }
                MW.Instance.PnlContainter.Controls["Platnosc"].BringToFront();
            }else if(rd_pozniej.Checked){
                MW.Instance.PnlContainter.Controls["Rezerwuj2"].BringToFront();
            }
            else
            {
                MessageBox.Show("Proszę wybrać rodzaj płatności", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

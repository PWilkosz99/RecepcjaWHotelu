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
    }
}

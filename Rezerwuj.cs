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
    public partial class Rezerwuj : UserControl
    {
        public Rezerwuj()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (!MW.Instance.PnlContainter.Controls.ContainsKey("Rezerwuj2"))
            {
                Rezerwuj2 rezerwuj2 = new Rezerwuj2();
                rezerwuj2.Dock = DockStyle.Fill;
                MW.Instance.PnlContainter.Controls.Add(rezerwuj2);
            }
            MW.Instance.PnlContainter.Controls["Rezerwuj2"].BringToFront();
        }
    }
}

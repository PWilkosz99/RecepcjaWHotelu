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
            
            MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if(!(txt_nrrez.Text == "") && (!(cmb_osob.Text == "")))
            {
                var rezerwacja = new Rezerwacja();
                rezerwacja.nrezerwacji = Int64.Parse(txt_nrrez.Text);
                rezerwacja.dataod = date_od.Value.ToShortDateString();
                rezerwacja.datado = date_do.Value.ToShortDateString();
                rezerwacja.ilosob = Int32.Parse(cmb_osob.Text);

                rezerwacja.czyparking = chk_parking.Checked;
                rezerwacja.czyrestauracja = chk_jedzenie.Checked;
                rezerwacja.czysilownia = chk_silownia.Checked;
                rezerwacja.czyspa = chk_spa.Checked;
                MW.CurrentC = txt_nrrez.Text;
                if (!rezerwacja.Rezerwuj())
                {
                    if (!MW.Instance.PnlContainter.Controls.ContainsKey("Rezerwuj2"))
                    {
                        Rezerwuj2 rezerwuj2 = new Rezerwuj2();
                        rezerwuj2.Dock = DockStyle.Fill;
                        MW.Instance.PnlContainter.Controls.Add(rezerwuj2);
                    }
                    MW.Instance.PnlContainter.Controls["Rezerwuj2"].BringToFront();
                    txt_nrrez.Text = DateTime.Now.Date.ToString("yyyyMMdd") + (MW.Counter + 2);
                    date_od.Value = DateTime.Now.Date;
                    date_do.Value = DateTime.Now.AddDays(1);
                    cmb_osob.SelectedIndex = 0;
                    chk_parking.Checked = false;
                    chk_jedzenie.Checked = false;
                    chk_silownia.Checked = false;
                    chk_spa.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij pozostałe dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txt_nrrez_KeyPress(object sender, KeyPressEventArgs e)
        {

                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Rezerwuj_Load(object sender, EventArgs e)
        {
            cmb_osob.SelectedIndex = 0;
            txt_nrrez.Text = DateTime.Now.Date.ToString("yyyyMMdd") + (MW.Counter+1); //TODO
            date_od.Value = DateTime.Now.Date;
            date_do.Value = DateTime.Now.AddDays(1) ;
        }
    }
}

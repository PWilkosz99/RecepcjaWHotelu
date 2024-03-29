﻿using System;
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
    public partial class Platnosc : UserControl
    {
        public Platnosc()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Klik pobiera informacje z formularza i uruchamia metode Ureguluj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (txt_kwota.Text != "" && (rd_gotowka.Checked == true || rd_karta.Checked == true))
            {
                Rachunek platnosc = new Rachunek();
                platnosc.wielkosc = Int32.Parse(txt_kwota.Text);
                platnosc.rezid = MW.CurrentC;
                if (rd_gotowka.Checked)
                {
                    platnosc.metoda = 'G';
                }
                else if (rd_karta.Checked)
                {
                    platnosc.metoda = 'K';
                }
                bool state = platnosc.Ureguluj();
                MW.CurrentC = "";
                if (state)
                    MW.Instance.PnlContainter.Controls["Menu"].BringToFront();
            }
            else
            {
                MessageBox.Show("Prosze uzupełnić pozostałe dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}

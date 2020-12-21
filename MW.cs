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
    public partial class MW : Form
    {
        static MW _obj;

        public static MW Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new MW();
                }
                return _obj;
            }
        }

        public Panel PnlContainter
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public MW()
        {
            InitializeComponent();
        }

        private void MW_Load(object sender, EventArgs e)
        {
            _obj = this;

            Login login = new Login();
            login.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(login);
        }
    }
}
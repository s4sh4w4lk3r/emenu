﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emenu.forms
{
    public partial class HallScreen : Form
    {
        public HallScreen()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Check();
        }
        public void Check()
        {
            var connection = SQLDB.connection;

        }
    }
}

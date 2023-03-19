using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace emenu
{
    public partial class HallScreen : Form
    {
        public HallScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int number = Order.HallScreenCheckOrder();
            if (number >= 0)
            {
                NewLabel(4, 89, number);
            }
        }
        void NewLabel(int x, int y, int number)
        {
            var l = new Label();
            l.AutoSize = true;
            l.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            l.ForeColor = SystemColors.Highlight;
            l.Location = new Point(4, 89);
            l.Size = new Size(90, 36);
            l.TabIndex = 2;
            l.Text = IOProcessing.ToThreeDigit(number);
        }
    }
}

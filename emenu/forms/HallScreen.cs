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
using emenu.Properties;
using MySql.Data.MySqlClient;

namespace emenu
{
    public partial class HallScreen : Form
    {
        public HallScreen()
        {
            InitializeComponent();
        }

        List<string> processingList = new List<string>();
        List<string> readyList = new List<string>();
        private void timer1_Tick(object sender, EventArgs e) //сделать дизайн
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            List<int> IntProcessingList = Order.GetProcessingIDsList().ToList();
            List<int> IntReadyList = Order.GetReadyIDsList().ToList();
            processingList = IntProcessingList.ConvertAll(x => IOProcessing.ToThreeDigit(x));
            readyList = IntReadyList.ConvertAll(x => IOProcessing.ToThreeDigit(x));
            listBox1.Items.AddRange(processingList.ToArray());
            listBox2.Items.AddRange(readyList.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order.RemoveReadyOrders();
        }
    }
}

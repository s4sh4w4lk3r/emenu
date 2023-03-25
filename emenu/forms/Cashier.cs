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

namespace emenu.forms
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();

        }

        public void MakeOrder()
        {
            List<int> list = IOProcessing.StringToList(textBox1.Text);
            string orderString = String.Empty;
            foreach (var item in list)
            {
                orderString += (item + ", ");
            }
            MessageBox.Show(orderString.TrimEnd(',', ' '));
            Debug.WriteLine("added to db " + orderString.TrimEnd(',', ' '));
            var order = new Order(list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeOrder();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLDB.ClearOrders();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var menu = new Menu(int.Parse(textBox2.Text));
            Debug.WriteLine($"id = {menu.id}, name = {menu.name}, price = {menu.price}");
            Debug.WriteLine(menu.picture);
            Debug.WriteLine(menu.desc);
        }
    }
}

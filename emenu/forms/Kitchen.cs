﻿using System;
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
    public partial class Kitchen : Form
    {
        public Kitchen()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
            dataGridView1.DefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Coral;
            Menu.FillMenuDict();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Order> orders = Order.GetOrdersKitchen().ToList();

            dataGridView1.RowCount = orders.Count + 1;
            for (int i = 0; i < orders.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = IOProcessing.ToThreeDigit(orders[i].orderID);
                dataGridView1.Rows[i].Cells[1].Value = IOProcessing.MenuIDsToNames(orders[i].menuIDs);
                dataGridView1.Rows[i].Cells[2].Value = "Pass Order";
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                bool parse = int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out int orderIDtoPass);
                if (!parse) { orderIDtoPass = -1; }
                Order.PassOrder(orderIDtoPass);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Order.RemoveReadyOrders();
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace emenu.forms
{
    public partial class Cashier : Form
    {
        List<Menu> menuList = Menu.GetMenuList();
        List<Menu> checkoutList = new List<Menu>();
        decimal totalPrice = 0;

        public Cashier()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
            dataGridView1.DefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Coral;
            FillDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Clear();
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int menuID = e.RowIndex + 1;
                Menu menuItem = menuList.Find(menu => menu.id == menuID) ?? new Menu();
                checkoutList.Add(menuItem);
            }
            totalPrice = 0;
            foreach (var item in checkoutList)
            {
                richTextBox1.Text += $"{item.name}\t{item.price}₽\n\n";
                totalPrice += item.price;
            }
            UpdatePrice();

        }
        private void FillDataGrid() //допилить картинки
        {
            dataGridView1.RowCount = menuList.Count + 1;
            for (int i = 0; i < menuList.Count; i++)
            {
                //dataGridView1.Rows[i].Cells[0].Value = Image.FromStream()
                dataGridView1.Rows[i].Cells[1].Value = menuList[i].name?.ToString();
                dataGridView1.Rows[i].Cells[2].Value = menuList[i].price.ToString() + "₽";
                dataGridView1.Rows[i].Cells[3].Value = "+";
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            checkoutList.Clear();
            richTextBox1.Clear();
            totalPrice = 0;
            UpdatePrice();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            List<int> checkoutToOrder = new List<int>();
            foreach (var item in checkoutList)
            {
                checkoutToOrder.Add(item.id);
            }
            new Order(checkoutToOrder);
        }

        private void UpdatePrice()
        {
            priceLabel.Text = $"Итого: {totalPrice}₽";
        }
    }
}

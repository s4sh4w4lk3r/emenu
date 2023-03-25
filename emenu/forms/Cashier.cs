using System;
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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
            FillDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                MessageBox.Show("Test");
            }
        }
        private void FillDataGrid()
        {
            List<Menu> menulist = Menu.GetMenuList();
            dataGridView1.RowCount = menulist.Count + 1;
            for (int i = 0; i < menulist.Count; i++)
            {
                Image image = Image.
                dataGridView1.Rows[i].Cells[0].Value = image;
                dataGridView1.Rows[i].Cells[1].Value = menulist[i].name?.ToString();
                dataGridView1.Rows[i].Cells[2].Value = menulist[i].price.ToString();
                dataGridView1.Rows[i].Cells[2].Value = "Add";
            }
        }
    }
}

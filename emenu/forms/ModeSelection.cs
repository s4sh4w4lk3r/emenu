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
    public partial class ModeSelection : Form
    {
        public ModeSelection()
        {
            InitializeComponent();
        }

        private void ModeSelection_Load(object sender, EventArgs e)
        {
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (CashierRadio.Checked) { StartCashier(); }
            if (HallScreenButton.Checked) { StartHallScreen(); }
            if (SelfServiceRadio.Checked) { StartSelfService(); }
            if (KitchenRadio.Checked) { StartKitchen(); }
        }

        void StartCashier()
        {
            Debug.WriteLine("Cashier Selected");
            Hide();
            var start = new Cashier();
            start.Closed += (s, args) => this.Close();
            start.Show();
        }
        void StartHallScreen()
        {
            Debug.WriteLine("Hall Screen Selected");
            Hide();
            var start = new HallScreen();
            start.Closed += (s, args) => this.Close();
            start.Show();
        }
        void StartSelfService()
        {   
            Debug.WriteLine("SelfService Selected");
            Hide();
            var start = new SelfService();
            start.Closed += (s, args) => this.Close();
            start.Show();
        }
        void StartKitchen()
        {
            Debug.WriteLine("Kitchen Selected");
            Hide();
            var start = new Kitchen();
            start.Closed += (s, args) => this.Close();
            start.Show();
        }
    }
}

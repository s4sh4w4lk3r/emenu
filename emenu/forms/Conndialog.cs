using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
namespace emenu.forms
{
    public partial class Conndialog : Form
    {
        public Conndialog()
        {
            InitializeComponent();

            HostnameBox.Text = Properties.Settings.Default.Hostname;
            UsernameBox.Text = Properties.Settings.Default.Username;
            PasswordBox.Text = Properties.Settings.Default.Password;
            DBnameBox.Text = Properties.Settings.Default.db_name;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void connButton_Click(object sender, EventArgs e)
        {
            ConnectFunction();
        }

        private void Conndialog_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConnectFunction();
            }
        }

        private void HostnameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConnectFunction();
            }
        }

        private void UsernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConnectFunction();
            }
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConnectFunction();
            }
        }

        private void DBnameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConnectFunction();
            }
        }

        private void SaveLoginButton_Click(object sender, EventArgs e)
        {
            emenu.Properties.Settings.Default.Hostname = HostnameBox.Text;
            emenu.Properties.Settings.Default.Username = UsernameBox.Text;
            emenu.Properties.Settings.Default.Password = PasswordBox.Text;
            emenu.Properties.Settings.Default.db_name = DBnameBox.Text;
            emenu.Properties.Settings.Default.Save();
        }

        private void ClearLoginButton_Click(object sender, EventArgs e)
        {
            HostnameBox.Text = null;
            UsernameBox.Text = null;
            PasswordBox.Text = null;
            DBnameBox.Text = null;
            emenu.Properties.Settings.Default.Hostname = null;
            emenu.Properties.Settings.Default.Username = null;
            emenu.Properties.Settings.Default.Password = null;
            emenu.Properties.Settings.Default.db_name = null;
            emenu.Properties.Settings.Default.Save();
        }

        private void ConnectFunction()
        {
            string hostname = HostnameBox.Text;
            string port;
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;
            string db_name = DBnameBox.Text;

            if (hostname.Contains(':')) // checking the string contains the port
            {
                int colonIndex = hostname.LastIndexOf(":");
                port = hostname.Substring(colonIndex + 1);
                hostname = hostname.Substring(0, colonIndex);
            } 
            else port = "3306";

            Debug.WriteLine($"Trying to connect to\n{username}@{hostname}:{port}\nDatabase Name: {db_name}");

            var connection = new SQLDB(hostname, port, username, password, db_name);
            if (connection.CheckLogin() == true) Start();
        }

        private void Start()
        {
            Dictionary<int, string> name = new Dictionary<int, string>();
            Dictionary<int, decimal> price = new Dictionary<int, decimal>();
            SQLDB.SQLSelectAll(ref name, ref price);
            for (int i = 1; i < name.Count; i++)
            {   
                Debug.WriteLine($"{i}\t{name[i]}\t{price[i]}");
            }
        }
    }
}

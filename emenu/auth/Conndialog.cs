using System.Diagnostics;
namespace emenu_csharp
{
    public partial class Conndialog : Form
    {
        public Conndialog()
        {
            InitializeComponent();

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

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

        private void ConnectFunction()
        {
            SQLDB connection = new SQLDB();
            string hostname = HostnameBox.Text;
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;
            string db_name = DBnameBox.Text;
            string port;

            if (hostname.Contains(":")) // checking the string contains the port
            {
                int colonIndex = hostname.LastIndexOf(":");
                port = hostname.Substring(colonIndex + 1);
                hostname = hostname.Substring(0, colonIndex);
            }
            else
            {
                port = "3306";
            }

            connection.GetParam(hostname, port, username, password, db_name);
            bool ConnnectionAvaliable = connection.OpenConnection();
            if (ConnnectionAvaliable == true)
            {
                Debug.WriteLine($"Connected to {DBnameBox.Text}");
                //Close();
                //MainWindow mainWindow = new MainWindow();
                //mainWindow.Show();
            }
        }
    }
}

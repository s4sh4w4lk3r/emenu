using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace emenu
{
    internal class SQLDB
    {
        MySqlConnection connection;
        public SQLDB(string host, string port, string user, string pass, string db_name)
        {
            connection = new MySqlConnection($"server={host};port={port};username={user};password={pass};database={db_name}");
        }
        public bool CheckLogin()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Введены некорректные данные");
                return false;
            }
            
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}

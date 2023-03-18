using System.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace emenu
{
    internal class SQLDB
    {
        public static MySqlConnection? connection;

        public SQLDB() { }

        public SQLDB(string host, string port, string user, string pass, string db_name)
        {
            connection = new MySqlConnection($"server={host};port={port};username={user};password={pass};database={db_name}");
        }

        public bool CheckLogin()

        {
            try
            {
                if (connection?.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    connection.Close();
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

        public static void CloseConnection()
        {
            if (connection?.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static MySqlConnection? GetConnection {get;}
    
        public static void ClearQuery()
        {
            connection?.Open();
            string query = "DELETE FROM orders;";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection?.Close();
        }
    }
}

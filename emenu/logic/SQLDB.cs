using System.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace emenu
{
    internal class SQLDB
    {
        
        //public static string? connString; // string with connection params
        public static string connString = "server=localhost;port=3306;username=admin;password=admin;database=emenu"; //temp
        public MySqlConnection connection {get; private set;} // just connection field for this class

        public SQLDB(string connString) //executing this constructor creates a connection object
        {
            connection = new MySqlConnection(connString);
        }

        public static bool CheckLogin(string host, string port, string user, string pass, string db_name) //needed to verify the login data
        {
            string connString = $"server={host};port={port};username={user};password={pass};database={db_name}";
            var testConnection = new MySqlConnection(connString);

            try
            {
                if (testConnection?.State == System.Data.ConnectionState.Closed)
                {
                    testConnection.Open();
                    testConnection.Close();
                    SQLDB.connString = connString;
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
        public static void ClearQuery() // clear table "orders"
        {
            var connection = new MySqlConnection(SQLDB.connString);
            connection?.Open();
            string query = "DELETE FROM orders;";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection?.Close();
        }

    }
}

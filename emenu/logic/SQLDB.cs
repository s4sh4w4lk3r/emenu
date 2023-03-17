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

        public static void SQLSelectAll(ref Dictionary<int, string> name, ref Dictionary<int, decimal> price)
        {
            
            connection?.Open();
            string query = "SELECT * FROM emenu";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            string? s1 = String.Empty;   int i1 = 0;
            string? s2 = String.Empty;   
            string? s3 = String.Empty;   decimal d3 = 0;
            while (reader.Read())
            {
                s1 = reader[0].ToString();  int.TryParse(s1, out i1);
                s2 = reader[1].ToString();
                s3 = reader[2].ToString();  decimal.TryParse(s3, out d3);
                
                name.Add(i1, s2 ??= "Empty");
                price.Add(i1, d3);
            }
            reader.Close();
            connection?.Close();
        }
    }
}

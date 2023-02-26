using MySql.Data.MySqlClient;

namespace emenu_csharp
{
    internal class SQLDB
    {

        //MySqlConnection connection = new MySqlConnection($"server={hostname};port=3306;username={username};password={password};database={db_name}");

        public void GetParam(string host, string port, string user, string pass, string db_name)
        {
            connection = new MySqlConnection($"server={host};port={port};username={user};password={pass};database={db_name}");
        }

        MySqlConnection connection;

        public bool OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    return true;
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введены некорректные данные");
            }
            return false;
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

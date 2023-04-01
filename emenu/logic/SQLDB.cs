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
        public static void ClearOrders() // clear table "orders"
        {
            var connection = new MySqlConnection(SQLDB.connString);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed.");
                return;
            }
            string delete = "DELETE FROM orders;";
            MySqlCommand command = new MySqlCommand(delete, connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            connection.Close();
        }
        public static void CheckCreateTables() //checking database tables and creates them if not exist
        {
            string createMenu = 
                "CREATE TABLE IF NOT EXISTS `menu` (" +
                "  `id` int NOT NULL AUTO_INCREMENT,"+
                "  `name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL," +
                "  `description` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,"+
                "  `price` decimal(5,2) NOT NULL,"+
                "  `picture` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL COMMENT 'link for pic',"+
                "  PRIMARY KEY (`id`)"+
                ") ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;";

            string createOrders = 
            "CREATE TABLE IF NOT EXISTS `orders` ("+
            "  `orderID` int NOT NULL,"+
            "  `menupos` varchar(512) COLLATE utf8mb4_unicode_ci NOT NULL,"+
            "  `status` tinyint UNSIGNED NOT NULL,"+
            "  UNIQUE KEY `orderID Unique` (`orderID`) USING BTREE"+
            ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;";
            
            string megaCreate = createMenu + "\n" + createOrders;

            var connection = new MySqlConnection(SQLDB.connString);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed.");
                return;
            }
            MySqlCommand command = new MySqlCommand(megaCreate, connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            connection.Close();
        }
        public static void TestMenuInsert()
        {

        }
        public static void TestOrderInsert()
        {
            MySqlConnection connection = new MySqlConnection(SQLDB.connString);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed.");
                return;
            }
            string insert = "INSERT INTO `orders` (`orderID`, `menupos`, `status`) VALUES " +
            "('111', '1 2 3 4 5 6', '0'), ('222', '7 8 9', '0'), ('333', '10 11', '0'), " +
            "('444', '12 13 14', '0'), ('555', '15 54 342', '0'), ('666', '32 76 87', '0'), " +
            "('777', '174 ', '0'), ('888', '78', '0'), ('999', '123', '0'), ('000', '312', '0')";
            MySqlCommand command = new MySqlCommand(insert, connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            connection.Close();
        }
    }

}

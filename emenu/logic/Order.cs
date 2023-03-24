using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace emenu
{
    internal class Order
    {
        public int[] listPos { get; } //pos from menu
        public int number { get; } //number of order (ex. 001)
        private static int counter; // staic number incrementer
        public bool status { get; private set; } // 0 - processing, 1 - ready
        public Order(params int[] listPos) //placing an order
        //when we get the number, an object will be created with the fields: 
        //list pos, number, status
        {
            if (counter > 999) counter = 0; //reset counter when == 999
            this.listPos = listPos;
            this.number = counter;
            counter++;
            var connection = new MySqlConnection(SQLDB.connString);
            connection?.Open();
            string query = "INSERT INTO orders (orderID, menupos, status) VALUES";

            if (listPos.Length == 1) query = $"INSERT INTO orders (orderID, menupos, status) VALUES ({counter}, {listPos[0]}, 0);";
            else
            {
                for (int i = 0; i < listPos.Length; i++)
                {
                    query += $"({counter}, {listPos[i]}, 0), ";
                }
                query = query.TrimEnd(' ', ',');
                query += ';';
            }

            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection?.Close();
        }
        
        #region //methods for hallscreen
        public static HashSet<int> GetProcessingList()
        {
            HashSet<int> processingList = new HashSet<int>();
            MySqlConnection conn = new MySqlConnection(SQLDB.connString);
            conn.Open();
            string sql = "SELECT orderID FROM orders WHERE status = 0";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int.TryParse(reader[0].ToString(), out int orderid);
                processingList.Add(orderid);
            }
            reader.Close(); 
            conn.Close();
            return processingList;
        }
        public static HashSet<int> GetReadyList()


        {
            HashSet<int> readyList = new HashSet<int>();
            MySqlConnection conn = new MySqlConnection(SQLDB.connString);
            conn.Open();
            string sql = "SELECT orderID FROM orders WHERE status = 1";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int.TryParse(reader[0].ToString(), out int orderid);
                readyList.Add(orderid);
            }
            reader.Close(); 
            conn.Close();
            return readyList;
        }
        #endregion
        public static void PassOrder(int orderId) //makes order status = 1
        {
            MySqlConnection connection = new MySqlConnection(SQLDB.connString);
            connection.Open();
            string query = $"UPDATE orders SET status = 1 WHERE orderID = {orderId};";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void RemoveReadyOrders() //remove orders which status = 1
        {
            MySqlConnection connection = new MySqlConnection(SQLDB.connString);
            connection.Open();
            string query = "DELETE FROM orders WHERE status = 1;";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        
    }
}

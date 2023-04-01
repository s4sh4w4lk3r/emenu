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
        public List<int> menuIDs { get; private set; } = null!; //pos from menu
        public int orderID { get; private set; } //number of order (ex. 001)
        private static int counter; // staic number incrementer
        public bool status { get; private set; } // 0 - processing, 1 - ready

        public Order(List<int> menuIDs) //placing an order
        //when we get the menuIDs, an object will be created with the fields: 
        //list menuIDs, number, status
        {
            if (counter > 999) counter = 0; //reset counter when == 999
            this.menuIDs = menuIDs;
            this.orderID = counter;
            string menupos = string.Empty;
            counter++;

            foreach (var item in this.menuIDs)
            {
                menupos += $"{item} ";
            }

            var connection = new MySqlConnection(SQLDB.connString);
            try
            {
                connection.Open();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed.");
            }
            string insert = $"INSERT INTO orders (orderID, menupos, status) VALUES ({orderID}, '{menupos}', 0)";
            MySqlCommand command = new MySqlCommand(insert, connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Maybe this is not the first launch, clear the order table.");
            }
            connection.Close();
        }
        public Order(int orderID) //ctor for getting orders method
        {
            this.orderID = orderID;
        }

        #region //methods for hallscreen
        public static HashSet<int> GetProcessingIDsList()
        {
            HashSet<int> processingList = new HashSet<int>();
            MySqlConnection connection = new MySqlConnection(SQLDB.connString);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed");
                return processingList;
            }
            string select = "SELECT orderID FROM orders WHERE status = 0";
            MySqlCommand command = new MySqlCommand(select, connection);
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int.TryParse(reader[0].ToString(), out int orderid);
                    processingList.Add(orderid);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.ToString()); };
            return processingList;
        }
        public static HashSet<int> GetReadyIDsList()
        {
            HashSet<int> readyList = new HashSet<int>();
            MySqlConnection connection = new MySqlConnection(SQLDB.connString);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed");
                return readyList;
            }
            string select = "SELECT orderID FROM orders WHERE status = 1";
            MySqlCommand command = new MySqlCommand(select, connection);
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int.TryParse(reader[0].ToString(), out int orderid);
                    readyList.Add(orderid);
                }
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            connection.Close();
            return readyList;
        }
        #endregion
        public static void PassOrder(int orderID) //makes order status = 1
        {
            if (orderID == -1) { return; }
            MySqlConnection connection = new MySqlConnection(SQLDB.connString);
            try
            {
                connection.Open();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed.");
            }
            string update = $"UPDATE orders SET status = 1 WHERE orderID = {orderID};";
            MySqlCommand command = new MySqlCommand(update, connection);
            try { command.ExecuteNonQuery(); } catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.ToString()); };
            connection.Close();
        }
        public static void RemoveReadyOrders() //remove orders which status = 1
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
            string delete = "DELETE FROM orders WHERE status = 1;";
            MySqlCommand command = new MySqlCommand(delete, connection);
            try { command.ExecuteNonQuery(); } catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.ToString()); };
            connection.Close();
        }
        public static Order GetOrder(int orderID) // getting full order fields from database
        {
            var order = new Order(orderID);

            MySqlConnection connection = new MySqlConnection(SQLDB.connString);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed.");
                return order;
            }
            string select = $"SELECT menupos, status FROM orders WHERE orderID = {orderID};";
            MySqlCommand command = new MySqlCommand(select, connection);
            try
            {
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string readerString = reader[0].ToString() ?? String.Empty;
                    order.menuIDs = IOProcessing.StringToList(readerString);
                    order.status = reader[1].ToString() == "1" ? true : false;
                    reader.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            connection.Close();
            return order;
        }
        public static HashSet<Order> GetOrdersKitchen()
        {
            HashSet<Order> kitchenOrdersList = new HashSet<Order>();

            MySqlConnection connection = new MySqlConnection(SQLDB.connString);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed.");
                return kitchenOrdersList;
            }
            string select = "SELECT orderID, menupos FROM orders WHERE status = 0";
            MySqlCommand command = new MySqlCommand(select, connection);
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int.TryParse(reader[0].ToString(), out int orderID);
                    kitchenOrdersList.Add(GetOrder(orderID));
                }
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());}
            connection.Close();
            return kitchenOrdersList;
        }
    }
}

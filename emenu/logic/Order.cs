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
        public byte status { get; private set; } // 0 - raw, 1 - on kitchen, 2 - on hallscreen, 12 - on kitchen & hallscreen,  3 - ready
        public Order(params int[] listPos) //placing an order
        //when we get the number, an object will be created with the fields: 
        //list pos, number, status for the kitchen and the screen in the hall
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
        public static int HallScreenCheckOrder() //return orderID and this order changes its status

        {
            MySqlConnection conn = new MySqlConnection(SQLDB.connString);
            int orderID = -1; 
            byte status = 255;
            conn.Open();
            string select = "SELECT orderID, status FROM orders WHERE status = 0 OR status = 1;";
            string update = "SELECT * FROM orders";
            MySqlCommand command = new MySqlCommand(select, conn);
            MySqlDataReader reader = command.ExecuteReader();
  
            reader.Read();
            int.TryParse(reader[0].ToString(), out orderID);
            byte.TryParse(reader[1].ToString(), out status);
            reader.Close();
            
            if (status == 0) update = $"UPDATE orders SET status=2 WHERE status=0 AND orderID={orderID};";
            if (status == 1) update = $"UPDATE orders SET status=12 WHERE status=1 AND orderID={orderID};";
            command = new MySqlCommand(update, conn);
            command.ExecuteNonQuery();
            conn.Close();
            return orderID;
        }
        //сделать такой же чекер для кухни
    }
}

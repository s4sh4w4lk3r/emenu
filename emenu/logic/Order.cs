using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace emenu
{
    internal class Order 
    {
        public int[] listPos {get;}
        public int number {get;}
        private static int counter;
        private bool isReady = false;
        public bool ISReady
        {
            get { return isReady; }
        }
        

        /// <summary>
        /// when creating an object, the order will be added to the database
        /// </summary>
        /// <param name="listPos"></param>
        public Order(params int[] listPos)
        {   
            if (counter > 999) counter = 0; //обнулятор 
            this.listPos = listPos;
            this.number = counter;
            counter++;
            var connection = SQLDB.connection;
            connection?.Open();
            string query = "INSERT INTO `orders`(`orderID`, `menupos`) VALUES";

            if (listPos.Length == 1) query = $"INSERT INTO `orders`( `orderID`, `menupos`) VALUES ({counter}, {listPos[0]});";
            else 
            {
                for (int i = 0; i < listPos.Length; i++)
                {
                    query += $"({counter}, {listPos[i]}), ";
                }
                query = query.TrimEnd(' ', ',');
                query += ';';
            }

            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection?.Close();
        }

        public void PrintOrder()
        {
            Console.WriteLine($"ID {this.number}\t");
            foreach (var item in this.listPos)
            {
                Console.Write(item + " ");
            }
        }
        public static void CloseOrder(ref Order? order)
        {
            order = null;
        }


    }
}

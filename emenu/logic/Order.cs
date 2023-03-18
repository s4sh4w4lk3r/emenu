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
        static int counter;

        public Order(params int[] listPos)
        {   
            if (counter > 999) counter = 0; //обнулятор 
            this.listPos = listPos;
            this.number = counter;
            counter++;
            var connection = SQLDB.connection;
            connection?.Open();
            string query = "INSERT INTO `query`(`orderID`, `menupos`) VALUES";

            if (listPos.Length == 1) query = $"INSERT INTO `query`( `orderID`, `menupos`) VALUES ({counter}, {listPos[0]});";
             else 
            {
                for (int i = 0; i > listPos.Length; i++)
                {
                    query += $" VALUES ({counter}, {listPos[i]}) "; //складывать строки запроса
                }
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
    }
}

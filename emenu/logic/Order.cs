using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

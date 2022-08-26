using System;
using customer;
using products;
using orders;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for Product info");
            Console.WriteLine("Press 2 for Customer info");
            Console.WriteLine("Press 3 for order details");

            int n = int.Parse(Console.ReadLine());

            

            switch(n)
            {
                case 1:
                    productinfo prod = new productinfo();
                    prod.show();
                    break;
                case 2:
                    customerinfo cust = new customerinfo();
                    cust.display();
                    break;
                case 3:
                    orderlist ord = new orderlist();
                    ord.orderdetails();
                    break;
            }
        }
    }
}

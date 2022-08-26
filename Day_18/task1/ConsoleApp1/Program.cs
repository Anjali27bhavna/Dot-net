using System;
using customer;
using products;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for Product info");
            Console.WriteLine("Press 2 for Customer info");

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
            }
        }
    }
}

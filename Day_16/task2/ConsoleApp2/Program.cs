using System;
using studentproject;
using price;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter 2 values");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //sample obj = new sample();
            //int z = obj.sum(a,b);
            //Console.WriteLine(z);


            Console.WriteLine("Enter 1 to insert products");
            Console.WriteLine("Enter 2 to insert prices");
            int n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    Console.WriteLine("Enter product");
                    item prod = new item();
                    prod.items = Console.ReadLine();
                    prod.show();
                    break;
                case 2:
                    Console.WriteLine("Enter price");
                    prices mrp = new prices();
                    mrp.price = int.Parse(Console.ReadLine());

                    mrp.show();
                    break;
                default:
                    Console.WriteLine("Enter a valid option!!!");
                    break;
            }

        }
    }
}

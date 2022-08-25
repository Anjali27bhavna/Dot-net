using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop statement

            //for (int x = 1; x <= 6; x++)
            //{
            //    for (int y = 1; y <= x; y++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            //array
            //int[] A = { 15, 20, 21, 25, 27, 30, 35 };
            //sample arr = new sample();
            //arr.printarray(A);


            //constructor
            //sample e1 = new sample(101, "Sonoo", 890000f);
            //sample e2 = new sample(102, "Mahesh", 490000f);
            //e1.display();
            //e2.display();

            //method overloading
            sample ob = new sample();
            int sum1 = ob.add(1, 2);
            Console.WriteLine("sum of two integer value " + sum1);

            float sum2 = ob.add(98f, 45f);
            Console.WriteLine("sum of two float value " + sum2);

            string sum3 = ob.add("Bhavna", "Corp");
            Console.WriteLine("sum of two string value " + sum3);




        }
    }
}

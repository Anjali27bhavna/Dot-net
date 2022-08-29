using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee { ID = 101, name = "Anjali", email = "jhgdjhsd" },
                new Employee { ID = 102, name = "poorva", email = "jhgdjhsd" },
                new Employee { ID = 103, name = "isha", email = "jhgdjhsd" },

            };
            foreach(Employee emps in emp)
            {
                Console.WriteLine(emps.ID + "/" + emps.name + "/" + emps.email);
                
            }

            //list and forEach loop
            List<int> numbers = new List<int>()
            {
                876,45,98,3,87,90,34,113,7,39
            };

            Console.WriteLine("Even numbers are: ");
            List<int> evennumbers = numbers.FindAll(x => (x % 2) == 0);
            foreach (var value in evennumbers)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Even numbers are: ");
            List<int> oddnumbers = numbers.FindAll(x => (x % 2) != 0);
            foreach (var value in oddnumbers)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            //partial clasees----------
            gfg1 Author_name = new gfg1("jeff", 20);
            Author_name.display();

        }
    }
}

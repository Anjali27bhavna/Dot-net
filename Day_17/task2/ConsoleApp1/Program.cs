using System;

namespace ConsoleApp1
{
    public struct employee
    {
        public int id;
        public string name;
        public double salary;

        class Program
        {
            static void Main(string[] args)
            {
                employee[] emp = new employee[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter the employee id: ");
                    emp[i].id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the employee name: ");
                    emp[i].name = Console.ReadLine();
                    Console.WriteLine("Enter the employee salary: ");
                    emp[i].salary = double.Parse(Console.ReadLine());
                }
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(emp[i].id + " " + emp[i].name + " " + emp[i].salary);
                }


            }
        }
    }
}

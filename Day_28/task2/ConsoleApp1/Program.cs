using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Anjali.Saini\Desktop\Dot net\Day_28\task2");
           
            //    if(directory.Exists)
            //    {
            //        Console.WriteLine("directory already exists");
            //        return;
            //    }
            //    directory.Create();


            FileStream stream = new FileStream(@"C: \Users\Anjali.Saini\Desktop\Dot net\Day_28\task2\serialization.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            employee emp = new employee(1, "manish");

            employee emp1 = (employee)formatter.Deserialize(stream);
            Console.WriteLine("id: " + emp1.empid);
            Console.WriteLine("name: " + emp1.empname);
        }
        class employee
        {
            public int empid;
            public string empname;
            public employee(int id, string name)
            {
                empid = id;
                empname = name;
            }
        }
    }
}

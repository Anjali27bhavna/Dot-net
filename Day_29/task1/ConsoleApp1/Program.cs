using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class employee
    {
        public string name { get; set; }
        public int age { get; set; }
    }
    class user
    {
        public string name { get; set; }
        private string[] emailids = new string[10];
        public string contact { get; set; }
        public string this[int index]
        {
            get { return emailids[index]; }
            set { emailids[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            employee emp = null;
            string employee = (emp != null) ? emp.name : null;
            Console.WriteLine(employee);

            var user = new user
            {
                [1] = "amit@gmail.com",
                [2]="mohit@gmail.com",
                [3]="anjali@gmail.com",
                [4]="naina@gmail.com",
                name="Rahul",
                contact="9348639487"
                
            };

            LogInfo();

            var book = new Tuple<string, string, Double>("C# in depth", "Anjali", 250);
            Console.WriteLine("-----------------------Book Record--------------------");
            Console.WriteLine("title " + book.Item1);
            Console.WriteLine("title " + book.Item2);
            Console.WriteLine("title " + book.Item3);

            var (name, email) = show();
            Console.WriteLine(name + " " + email);

            string nam = "mark";
            var date = DateTime.Now;
            //normal printing methods
            Console.WriteLine("hello " + nam + "it is " + DateTime.Now);
            Console.WriteLine("hello {0} it is {1}", nam, DateTime.Now);
            //string iterpolation
            Console.WriteLine($"hello {nam} it is {DateTime.Now}");
        }

        static void LogInfo([CallerMemberName] string MethodName = "", [CallerLineNumberAttribute] int linenumber = 0, [CallerFilePathAttribute] string source = "")
        {
            Console.WriteLine("Welcome to C#");
            Console.WriteLine(MethodName);
            Console.WriteLine(source);
        }

        //--------multi argument method-----------
        static (string name, string email) show()
            {
            return ("anjali","anjali@gmail.com");
            }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class genericclass<T>
    {
        public T msg;
        public int a = 10;
        public void genericmethod(T name,T location)
        {
            Console.WriteLine(msg);
            Console.WriteLine(name);
            Console.WriteLine(location);
            Console.WriteLine(a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //genericclass<string> gc = new genericclass<string>();
            //gc.msg = "welcome";
            //gc.genericmethod("Anjali", "Noida");

            //-----------params---------------
            int y = sample.add(10, 20, 20);
            Console.WriteLine(y);
        }
    }
    //------------base keyword---------------
    public class book
    {
        protected string ISBN = "1234";
        protected string bookname = "Let us C#";

        public virtual void getinfo()
        {
            Console.WriteLine("Book name : " + bookname);
            Console.WriteLine("ISBN is : " + ISBN);
        }

        
    }
    public class student : book
    {
        public int studentid = 101;
        public override void getinfo()
        {
            Console.WriteLine("Student id is : " + studentid);
            base.getinfo(); //contents from getinfo of base class  will get 

            user ulist = new user();
            ulist[0] = "suresh";
            ulist[1] = "mahesh";
            ulist[3] = "ramesh";

            for (int i= 0;i<3;i++)
            {
                Console.WriteLine(ulist[i]);
            }

            var employee = new List<employee>()
            {
                new employee(){name="anjali",salary=2000},
                new employee(){name="naina",salary=5000},
                new employee(){name="devesh",salary=1000},

            };

            var items = employee.Where(x => x.salary > 1000);
            //foreach(var list in items)
            
                Console.WriteLine(items.Count());

            foreach(employee emp in items)
            {
                Console.WriteLine(emp.name + "/"+ emp.salary);
            }
            
        }
    }

    public class employee
    {
        public string name;
        public int salary;

    }
    class sample
    {
        public static int add(params int[] numbers)
        {
            int total=0;
            foreach(int i in numbers)
            {
                total += i;
            }
            return total;
        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        public class employee : IDisposable
        {
            //dispose works same as destructor but you do not have control on destructor but you can dispose your object
            //whenever you called it
            public void Dispose()
            {
                Console.WriteLine("inside dispose");
            }
            public int a;
            //constructor
            //public employee()
            //{
            //    a = 10;
            //    Console.WriteLine("instructor is invoked");
            //}

            //destructor
            //~employee()
            //{
            //    Console.WriteLine("destructor is invoked");
            //}
            static void Main(string[] args)
            {
                //int x = default(int);
                //Console.WriteLine(x); 
                //default - checks what kind of data you are passing

                employee obj = new employee();
                //Console.WriteLine("hey check the position of constructor");
                Console.WriteLine("hello world");
                obj.Dispose(); //destroyed
            }
        }
    }
}

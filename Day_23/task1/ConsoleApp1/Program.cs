using System;
using ClassLibrary1;
using static ClassLibrary1.Class1;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            complex c1 = new complex(10, 20);
            c1.show(); //10 & 20
            complex c2 = new complex();
            c2.show(); //0 & 0
            c2 = -c1;
            c2.show(); //-10 & -20

            //-------------reference type------------
            person p1 = new person();
            person p2 = new person();
            p1.age = 5;
            p2.age = 10;
            Console.WriteLine(p1.age + " " + p2.age);
            square(p1, p2); //passing the address of p1 p2 in the function
            Console.WriteLine(p1.age + " " + p2.age);

            //==================base class==============
            Object obj = new object();  //default class
            int i = 10;

            Type t1 = obj.GetType();
            Type t2 = i.GetType();

            Console.WriteLine(t1.BaseType); //no output
            Console.WriteLine(t1.Name); //Object
            Console.WriteLine(t1.FullName); // system.object
            Console.WriteLine(t1.Namespace);//system

            Console.WriteLine(t2.BaseType); //system.valuetype
            Console.WriteLine(t2.Name); //int32
            Console.WriteLine(t2.FullName); //system.int32
            Console.WriteLine(t2.Namespace);//system
            //================================================
        }

        
    }
}

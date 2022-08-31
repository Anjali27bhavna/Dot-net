using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class sample
    {
        //public int id;
        //public String name;
        //public float salary;
        //public sample(int i, String n, float s)
        //{
        //    id = i;
        //    name = n;
        //    salary = s;
        //}
        //public void display()
        //{
        //    Console.WriteLine(id + " " + name + " " + salary);
        //}

        public int add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public float add(float a, float b)
        {
            float sum = a + b;
            return sum;
        }
        public string add(string a, string b)
        {
            string sum = a + b;
            return sum;
        }

        public virtual void show()
        {
            Console.WriteLine("Base class");
        }
    }
}

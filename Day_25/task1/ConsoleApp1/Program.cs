using System;
using System.Collections;
using System.Collections.Generic;

using System.Timers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------collection-----------------

            List<string> obj = new List<string>()
            {
                "mohit","anjali","naina"    //list can contain duplicate values
            };
            foreach(var name in obj)
            {
                Console.WriteLine(name);
            }
            //----------------------------------

            //=========hashset==================
            var names = new HashSet<string>();
            names.Add("India");
            names.Add("India");
            names.Add("India");
            names.Add("India");
            names.Add("India");
            //it will not take duplicate values
            foreach(var n in names)
            {
                Console.WriteLine(n);
            }
            //================sorted set==============

            //can not store duplicate values and will have values in a sorted manner 

            var countr = new SortedSet<string>();
            countr.Add("India");
            countr.Add("Australia");
            countr.Add("USA");

            foreach(var n in countr)
            {
                Console.WriteLine(n);
            }

            //===================stack==================
            //LIFO

            var num = new Stack<int>();
            num.Push(10);
            num.Push(20);
            num.Push(19);
            num.Push(22);
            num.Push(4);

            foreach(var i in num)
            {
                Console.WriteLine(i);     //4,22,19,20,10
            }

            num.Pop();               //top of the stack will be deleted
            foreach (var i in num)
            {
                Console.WriteLine(i);   //22,19,20,10
            }
            Console.WriteLine(num.Peek());       //22           displayed top element of the stack

            //====================queue==================
            //FIFO

            var nums = new Queue<int>();
            nums.Enqueue(10);
            nums.Enqueue(20);
            nums.Enqueue(19);
            nums.Enqueue(22);
            nums.Enqueue(4);

            foreach (var i in nums)
            {
                Console.WriteLine(i);     //10,20,19,22,4
            }
            nums.Dequeue();
            foreach (var i in nums)
            {
                Console.WriteLine(i);     //20,19,22,4
            }

            //====================linked list=================

            var ll = new LinkedList<string>();
            ll.AddLast("amit");
            ll.AddLast("loki");
            ll.AddLast("thor");

            //foreach(var n in ll)
            //{
            //    Console.WriteLine(n);
            //}
            LinkedListNode<string> node = ll.Find("loki");
            ll.AddBefore(node, "thanos");

            foreach (var n in ll)
            {
                Console.WriteLine(n);     //amit,thanos,loki,thor
            }

            //====================dictionary===================

            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("1", "bob");
            d.Add("2", "alex");
            d.Add("3", "robin");
            d.Add("4", "carl");

            foreach(KeyValuePair<string,string> k in d)
            {
                //Console.WriteLine(k.Key);           //1,2,3,4
                Console.WriteLine(k.Key+" "+ k.Value);
            }

            person obj1 = new person();
            foreach(var n in obj1)
            {
                Console.WriteLine(n);
            }
            //event driven program

            Timer t = new Timer(2000);
            t.Enabled = true;
            t.Elapsed += new ElapsedEventHandler(TimeHandler);
            for(int i=0;i<100;i++)
            {
                for(int j=0;j<1000;j++)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void TimeHandler(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        class person : IEnumerable
        {
           
            private int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            public int age { get; set; }
            public string name { get; set; }
            public IEnumerator GetEnumerator()
            {
                return list.GetEnumerator();
            }
        }
        
      
        
    }
}

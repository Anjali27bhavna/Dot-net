using System;
using System.Threading;
using System.Timers;

namespace ConsoleApp1
{
    class Program
    {
        //thread lock
        static readonly object pblock = new object();
        static void PrintInfo()
        {
            lock (pblock)
            {
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine("i value: {0}", i);
                    Thread.Sleep(1000);
                }
            }
        }
        static void Main(string[] args)
        {
            ////single thread
            //PrintInfo1();
            //PrintInfo2();
            //Console.ReadLine();

            //multithreading
            Thread t1 = new Thread(new ThreadStart(PrintInfo1));
            Thread t2 = new Thread(new ThreadStart(PrintInfo2));
            t1.Start();
            t2.Start();
            Console.ReadLine();

            //sleep
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread paused for {0} second", 1);
                // Pause thread for 1 second
                Thread.Sleep(1000);
                Console.WriteLine("i value: {0}", i);
            }
            Console.ReadLine();

            //thread lock
            //Thread t1 = new Thread(new ThreadStart(PrintInfo));
            //Thread t2 = new Thread(new ThreadStart(PrintInfo));
            //t1.Start();
            //t2.Start();
            //Console.ReadLine();

            //timer
            Console.WriteLine("Present Enter Key to Exit the Application");

            // create a timer
            //Timer timer = new Timer();
            //timer.Interval = 2000;
            //timer.Elapsed += TimerEvent;
            //timer.AutoReset = true;
            //timer.Enabled = true;
            //Console.ReadLine();
        }
        static void TimerEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Event Raised at {0:HH:mm:ss.fff}", e.SignalTime);
        }
        //static void PrintInfo1()
        //{
        //    for (int i = 1; i <= 4; i++)
        //    {
        //        Console.WriteLine("i value: {0}", i);
        //        Thread.Sleep(1000);
        //    }
        //    Console.WriteLine("First method completed");
        //}
        //static void PrintInfo2()
        //{
        //    for (int i = 1; i <= 4; i++)
        //    {
        //        Console.WriteLine("i value: {0}", i);
        //    }
        //    Console.WriteLine("Second method completed");
        //}
        //multi
        static void PrintInfo1()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("i value: {0}", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("First method completed");
        }
        static void PrintInfo2()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("i value: {0}", i);
            }
            Console.WriteLine("Second method completed");
        }
    }
}

using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void method1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Method1: {i}");
            }
        }
        static void method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Method2: {i}");
                if (i == 3)
                {
                    Console.WriteLine($"Started performing thread operation");
                    Thread.Sleep(4000);
                    Console.WriteLine($"Completed performing thread operation");
                }
            }
        }
        static void method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Method3: {i}");
            }
        }

        static void Main(string[] args)
        {
            //Creating instance of Thread
            Thread currentThread = Thread.CurrentThread;

            //Get name of Thread
            Console.WriteLine($"Thread: {currentThread.Name}");

            currentThread.Name = "Main";
            Console.WriteLine($"Thread name: {currentThread.Name}");
            Console.WriteLine($"Thread Id: {currentThread.ManagedThreadId}");
            Console.WriteLine($"Thread is Alive? : {currentThread.IsAlive}");
            Console.WriteLine($"Priority of Thread: {currentThread.Priority}");
            Console.WriteLine($"Status of Thread: {currentThread.ThreadState}");
            Console.WriteLine($"IsBackground: {currentThread.IsBackground}");

            Console.ReadKey();

            // Create a new Thread
            Thread MainThread = new Thread(Print);
            // Run thread
            MainThread.Start();

            // Actions that we make in the Main Thread
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Main Thread: {i}");
                //Pause thread
                Thread.Sleep(300);
            }

            // Actions from second thread
            void Print()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Second Thread: {i}");
                    Thread.Sleep(400);
                }
            }
            private static void method3(object obj)
            {
                Console.WriteLine("Method 3 started using", Thread.CurrentThread.Name);
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine($"Method3: {i}");
                }
                Console.WriteLine("Method 3 ended using", Thread.CurrentThread.Name);
            }

            private static void method2(object obj)
            {
                Console.WriteLine("Method 2 started using", Thread.CurrentThread.Name);
                for (int i = 0; i <= 5; i++)
                {
                    if (i == 3)
                    {
                        Console.WriteLine("Started performing thread operation");
                        Thread.Sleep(500);
                        Console.WriteLine("Ended performing thread operation");
                    }
                    Console.WriteLine($"Method1: {i}");
                }
                Console.WriteLine("Method 2 ended using", Thread.CurrentThread.Name);
            }

            private static void method1(object obj)
            {
                Console.WriteLine("Method 1 started using", Thread.CurrentThread.Name);
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine($"Method1: {i}");
                }
                Console.WriteLine("Method 1 ended using", Thread.CurrentThread.Name);
            }
        }

    }
}

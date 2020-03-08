using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threading
{
    class Program
    {
   
        public static void CallNewThread()
        {
            try
            {
                Console.WriteLine("A new child thread will start now.");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(i);
                }
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread Abort Exception");
            }
            finally
            {
                Console.WriteLine("Is not catched by Thread Exception.");
            }
            int sleeping = 1000; // thread will pause for 1 second
            Console.WriteLine("Child Thread will pause for {0} seconds", sleeping/10000);
            Thread.Sleep(sleeping);
            Console.WriteLine("Now the Thread is awake.");
        }
        static void Main(string[] args)
        {
            ThreadStart child = new ThreadStart(CallNewThread);
            Console.WriteLine("Main Method: A Child Thread is being Created...");
            Thread childThread = new Thread(child);
            childThread.Start();
            Console.ReadKey();
            
        }
    }
}

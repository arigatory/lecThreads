using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lecThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Thread.Sleep(5000);
            Thread thread1 = new Thread(() => Console.WriteLine(Do("first thread id in Do method")) );
            thread1.IsBackground = true;
            thread1.Priority = ThreadPriority.BelowNormal;
            thread1.Start();

            Thread thread2 = new Thread(() => Console.WriteLine(Do("second thread id in Do method")));
            thread2.IsBackground = true;
            thread2.Priority = ThreadPriority.Lowest;
            thread2.Start();

            //Thread.Sleep(2000);
            //Do("Main thread id in Do method");
            Console.WriteLine($"Main thread id {Thread.CurrentThread.ManagedThreadId}");
            Console.ReadLine();
            
        }
        private static int Do(string message)
        {
            while (true)
            {
                Console.WriteLine($"{message} {Thread.CurrentThread.ManagedThreadId} - {DateTime.Now}");
            }
            return Thread.CurrentThread.ManagedThreadId;
        }
    }
}

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
            Thread thread1 = new Thread(() => Console.WriteLine(Do("first thread id in Do method")) );
            thread1.IsBackground = true;
            thread1.Start();

            Thread thread2 = new Thread(() => Console.WriteLine(Do("second thread id in Do method")));
            thread2.IsBackground = true;
            thread2.Start();

            Thread.Sleep(2000);
            //Do("Main thread id in Do method");
          Console.WriteLine($"Main thread id {Thread.CurrentThread.ManagedThreadId}");
            
        }
        private static int Do(object data)
        {
            string message = (string)data;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{message} {Thread.CurrentThread.ManagedThreadId} - {DateTime.Now}");
                Thread.Sleep(1000);
            }
            return Thread.CurrentThread.ManagedThreadId;
        }
    }
}

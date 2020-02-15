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
            Thread thread = new Thread(Do);
            thread.Start("first thread id in Do method");

            thread = new Thread(Do);
            thread.Start("second thread id in Do method");
            Do("Main thread id in Do method");
          //  Console.WriteLine($"Main thread id {Thread.CurrentThread.ManagedThreadId}");
            Console.ReadLine();
        }
        private static void Do(object data)
        {
            string message = (string)data;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{message} {Thread.CurrentThread.ManagedThreadId} - {DateTime.Now}");
                Thread.Sleep(100);

            }
        }
    }
}

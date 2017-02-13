using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadsExample003
{
    class Program
    {
        static void WriteSecond()
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "Secondary";

            Console.WriteLine($"{thread.Name} threadID is {thread.GetHashCode()}");

            for (int count = 0; count < 10; count++)
            {
                Console.WriteLine(new string(' ',15) + thread.Name +count);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";

            Console.WriteLine($"{primaryThread.Name} threadID is {primaryThread.Name.GetHashCode()}");


            Thread secondaryThread = new Thread(WriteSecond);
            secondaryThread.Start();

            for (int count = 0; count < 10; count++)
            {
                Console.WriteLine(primaryThread.Name + " " + count);
                Thread.Sleep(1500);
            }

        }
    }
}

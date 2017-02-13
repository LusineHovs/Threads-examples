using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadsExample002
{
    class Program
    {
        static void WriteSecond()
        {
            int counter = 0;
            while (counter<10)
            {
              //  Thread.Sleep(500);
                Console.WriteLine($"ThreadID ={Thread.CurrentThread.GetHashCode()}, Counter={counter}");
                counter++;
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(WriteSecond);
            thread.Start();


            WriteSecond();
            Console.ReadKey();

        }
    }
}

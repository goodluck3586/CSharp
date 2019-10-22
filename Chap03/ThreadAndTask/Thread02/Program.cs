using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/* 611p 예제 */
namespace Thread02
{
    class Program
    {
        static void DoSomething()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);
            }
        }
        static void Main(string[] args)
        {
            //Thread t = new Thread(new ThreadStart(DoSomething));
            Thread t1 = new Thread(DoSomething);
            Console.WriteLine("Starting thread...");
            t1.Start();

            //Thread t2 = new Thread(DoSomething);
            //t2.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main : {i}");
                Thread.Sleep(10);
            }

            Console.WriteLine("Waiting until thread stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}

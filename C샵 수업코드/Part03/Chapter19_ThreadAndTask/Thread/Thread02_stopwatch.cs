using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex02_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 객체 생성
            var a1 = new AAA() { Name = "A" };
            var a2 = new AAA() { Name = "B" };
            var a3 = new AAA() { Name = "C" };

            // 2. 스레드 생성
            var t1 = new Thread(new ThreadStart(a1.PrintName));     // 정식 방법
            var t2 = new Thread(a2.PrintName);                      // 약식 방법
            var t3 = new Thread(a3.PrintName);

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // 3. 스레드 시작
            t1.Start();
            t2.Start();
            t3.Start();

            // Thread를 사용하지 않는 처리
            //a1.PrintName();
            //a2.PrintName();
            //a3.PrintName();

            // 4. 모든 스레드가 종료될 때까지 대기
            t1.Join();
            t2.Join();
            t3.Join();

            stopwatch.Stop();
            Console.WriteLine($"경과시간: {stopwatch.ElapsedMilliseconds}ms");
        }
    }

    class AAA
    {
        public string Name { get; set; }

        public void PrintName()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Name);
                Thread.Sleep(10);
            }
        }
    }
}

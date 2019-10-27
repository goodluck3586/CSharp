using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* 비동기식 아침식사 준비 */
namespace MakeBreakfast02_Async
{
    class Egg
    {

    }
    class Bacon
    {

    }
    class Toast
    {

    }
    class Juice { }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;  // 시작 시간

            Console.WriteLine("***** 아침식사 준비 시작 *****\n");

            Task<Egg> eggs = FryEggs(2);
            var bacon = FryBacon(3);      
            var toast = ToastBread(2);
                 
            eggs.Wait();
            Console.WriteLine("eggs are ready");
            bacon.Wait();
            Console.WriteLine("bacon is ready");
            toast.Wait();
            Console.WriteLine("toast is ready");
            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");

            DateTime endTime = DateTime.Now;
            TimeSpan elapsed = endTime - startTime;  // TimeSpan 두 날짜 간의 시간 간격
            Console.WriteLine($"실행 시간 : {elapsed}");
        }

        async private static Task<Egg> FryEggs(int v)
        {
            Console.WriteLine("계란 준비");
            Egg egg = new Egg();

            await Task.Run(() =>
            {
                for (int i = 0; i < v; i++)
                {
                    Console.WriteLine($"계란 후라이 만들기 {i}");
                    Thread.Sleep(1000);
                }
            });
            
            return egg;
        }

        async private static Task<Bacon> FryBacon(int v)
        {
            Console.WriteLine("베이컨 준비");
            Bacon bacon = new Bacon();

            await Task.Run(() =>
            {
                for (int i = 0; i < v; i++)
                {
                    Console.WriteLine($"베이컨 만들기 {i}");
                    Thread.Sleep(1000);
                }
            });
            
            return bacon;
        }

        async private static Task<Toast> ToastBread(int v)
        {
            Console.WriteLine("토스트빵 준비");
            Toast toast = new Toast();

            await Task.Run(() =>
            {
                for (int i = 0; i < v; i++)
                {
                    Console.WriteLine($"토스트 빵 굽기 {i}");
                    Thread.Sleep(1000);
                }
            });
            ApplyButter(toast);
            ApplyJam(toast);
            return toast;
        }

        private static void ApplyButter(Toast toast)
        {
            Console.WriteLine("빵에 버터를 바른다.");
        }

        private static void ApplyJam(Toast toast)
        {
            Console.WriteLine("빵에 잽을 바른다.");
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("오렌지 주스를 따른다.");
            return new Juice();
        }
    }
}
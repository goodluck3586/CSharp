using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTest01
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

    class Program
    {
        static void Main(string[] args)
        {
            MakeBreakfast();
            Console.WriteLine("메인 스레드");
            Console.ReadLine();
        }

        async private static void MakeBreakfast()
        {
            Console.WriteLine("***** 아침식사 준비 시작 *****\n");
            //var eggsTask = FryEggsAsync(4);
            //var baconTask = FryBaconAsync(2);
            //var toastTask = MakeToastWithButterAndJamAsync(2);
            
            FryEggsAsync(4);
            FryBaconAsync(4);
            MakeToastWithButterAndJamAsync(2);

            Console.WriteLine("친구가 아침 식사 준비가 다 되었는지 물어봄 1");
            Thread.Sleep(2000);
            Console.WriteLine("친구가 아침 식사 준비가 다 되었는지 물어봄 2");

            /*var eggs = await eggsTask;
            Console.WriteLine("eggs are ready");
            var bacon = await baconTask;
            Console.WriteLine("bacon is ready");
            var toast = await toastTask;
            Console.WriteLine("toast is ready");*/

            Console.WriteLine("\n***** 아침식사 준비 완료 *****");
        }

        async private static Task<Egg> FryEggsAsync(int v)
        {
            Console.WriteLine("계란 준비");
            Egg egg = new Egg();

            await Task.Run( () =>
            {
                for (int i = 0; i < v; i++)
                {
                    Console.WriteLine($"계란 후라이 만들기 {i}");
                    Thread.Sleep(1000);
                }
            });
            Console.WriteLine("** 계란 후라이 완성 **\n");
            return egg;
        }

        async private static Task<Bacon> FryBaconAsync(int v)
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
            Console.WriteLine("** 베이컨 완성 **\n");
            return bacon;
        }

        async static Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            Console.WriteLine("토스트 재료 준비");
            Toast toast = new Toast();

            await Task.Run(() =>
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine($"토스트빵 굽는 중 {i}");
                    Thread.Sleep(1500);
                }
                Console.WriteLine("\n** 토스트빵 굽기 완료. **\n");
            });

            ApplyButter();
            ApplyJam();

            void ApplyButter()
            {
                Console.WriteLine("토스트빵에 버터를 바른다.");
            }
            void ApplyJam()
            {
                Console.WriteLine("토스트빵에 잼을 바른다.");
            }

            return toast;
        }
    }
}

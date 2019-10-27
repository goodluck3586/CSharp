using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");
            Task<Egg> eggTask = FryEggs(2);
            Egg eggs = await eggTask;
            Console.WriteLine("eggs are ready");
            Task<Bacon> baconTask = FryBacon(3);
            Bacon bacon = await baconTask;
            Console.WriteLine("bacon is ready");
            //Task<Toast> toastTask = ToastBread(2);
            //Toast toast = await toastTask;
            //ApplyButter(toast);
            //ApplyJam(toast);
            //Console.WriteLine("toast is ready");
            //Juice oj = PourOJ();
            //Console.WriteLine("oj is ready");

            Console.WriteLine("Breakfast is ready!");
        }

        private static Task<Egg> FryEggs(int v)
        {
            return Task<Egg>.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("계란 후라이를 한다.");
                return new Egg();
            });
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("커피를 잔에 따른다.");
            return new Coffee();
        }

        private static Task<Bacon> FryBacon(int v)
        {
            return Task<Bacon>.Run(() =>
            {
                Console.WriteLine("베이컨을 한다.");
                return new Bacon();
            });
        }

        private static Task<Toast> ToastBread(int v)
        {
            throw new NotImplementedException();
        }

        private static Juice PourOJ()
        {
            throw new NotImplementedException();
        }

        private static void ApplyJam(Toast toast)
        {
            throw new NotImplementedException();
        }

        private static void ApplyButter(Toast toast)
        {
            throw new NotImplementedException();
        }
    }

    internal class Toast
    {
    }

    internal class Juice
    {
    }

    internal class Bacon
    {
    }

    internal class Egg
    {
    }

    internal class Coffee
    {
    }
}

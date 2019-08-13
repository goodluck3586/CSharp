using System;
using static System.Console;

namespace HelloWorld02
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("사용법: HelloWorld.exe 이름");
                return;
            }

            WriteLine(args.Length);
            WriteLine("Hello {0}", args[0]);
            WriteLine($"Hello {args[1]}");
        }
    }
}

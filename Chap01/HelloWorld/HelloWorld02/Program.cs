using System;
using static System.Console;

/* D:\Repository\CSharp\Chap01\HelloWorld\HelloWorld02\bin\Debug>HelloWorld02.exe 아이유 이선균 */
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
            WriteLine($"Hello {args[1]}");  // 문자열 보간법
            
        }
    }
}

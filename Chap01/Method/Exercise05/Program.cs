using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            // 반복문을 이용한 피보나치 수열 출력
            Console.WriteLine("반복문을 이용한 피보나치 수열 출력");
            for (ulong i = 0; i <= 20; i++)
                Console.WriteLine($"FibonacciLoop({i,-3}) : {Calculator.FibonacciLoop(i)}");
            //Console.WriteLine($"{Calculator.FibonacciLoop(i)}");

            // 재귀호출을 이용한 피보나치 수열 출력
            Console.WriteLine("재귀호출을 이용한 피보나치 수열 출력");
            for (ulong i = 0; i <= 20; i++)
                Console.WriteLine($"FibonacciRecursive({i,-3}) : {Calculator.FibonacciRecursive(i)}");
        }
    }
}

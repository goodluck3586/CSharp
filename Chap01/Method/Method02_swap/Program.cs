using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 참조에 의한 매개변수 전달 ref, out */
namespace Method02_swap
{
    class Program
    {
        static void Main(string[] args)
        {
            // ref를 이용한 참조에 의한 매개변수 전달
            int x = 3, y = 4;
            Console.WriteLine($"x:{x}, y:{y}");
            Swap(ref x, ref y);
            Console.WriteLine($"x:{x}, y:{y}");
            Console.WriteLine();

            // out을 이용한 참조에 의한 매개변수 전달
            int a = 20, b = 3;
            Divide(a, b, out int quotient, out int remainder);
            Console.WriteLine($"a: {a}, b: {b}, a/b: {quotient}, a%b: {remainder}");

        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        private static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
    }
}

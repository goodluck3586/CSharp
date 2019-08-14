using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            Console.WriteLine("Input : {0}, {1}", a, b);

            int result = a + b;
            return result;
        }

        public static ulong FibonacciRecursive(ulong n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
            }
        }

        public static ulong FibonacciLoop(ulong n)
        {
            ulong cnt = 0, value1 = 0, value2 = 1, returnValue = 0;
            while (cnt != n)
            {
                returnValue = value2; //두번째 value 값을 출력하기 위해
                value2 += value1; // 두번째 값에 첫번째 값을 더한다
                value1 = returnValue; // 첫번째 값에 두번째 값을 대입한다.
                cnt++;
            }
            return returnValue;
        }
    }
}

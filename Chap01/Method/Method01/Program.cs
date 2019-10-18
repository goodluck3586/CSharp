using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method01
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            Console.WriteLine("Input : {0}, {1}", a, b);
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = Calculator.Plus(3, 4);
            int y = Calculator.Plus(5, 6);
            int z = Calculator.Plus(7, 8);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}

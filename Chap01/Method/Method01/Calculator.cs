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

            int result = a + b;
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plus(1, 2)");
            Console.WriteLine(Plus(1, 2));

            Console.WriteLine("Plus(1.2, 3.4)");
            Console.WriteLine(Plus(1.2, 3.4));
        }

        private static double Plus(double v1, double v2)
        {
            return v1 + v2;
        }

        private static int Plus(int v1, int v2)
        {
            return v1 + v2;
        }
    }
}

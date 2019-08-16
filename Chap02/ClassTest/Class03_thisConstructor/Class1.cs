using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03_thisConstructor
{
    class Class1
    {
        int a, b, c;

        public Class1()
        {
            this.a = 5425;
            Console.WriteLine($"Class1()");
        }

        public Class1(int b)
        {
            this.a = 5425;
            this.b = b;
            Console.WriteLine($"Class1({b})");
        }

        public Class1(int b, int c)
        {
            this.a = 5425;
            this.b = b;
            this.c = c;
            Console.WriteLine($"Class1({b}, {c})");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a:{a}, b:{b}, c:{c}");
            Console.WriteLine();
        }
    }
}

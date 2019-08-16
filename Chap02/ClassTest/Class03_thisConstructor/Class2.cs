using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03_thisConstructor
{
    class Class2
    {
        int a, b, c;

        public Class2()
        {
            this.a = 5425;
            Console.WriteLine($"Class2()");
        }

        public Class2(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"Class2({b})");
        }

        public Class2(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"Class2({b}, {c})");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a:{a}, b:{b}, c:{c}");
            Console.WriteLine();
        }
    }
}

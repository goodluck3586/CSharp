using System;

namespace Ex08_Class_thisConstructor
{
    internal class Class1
    {
        int a, b, c;

        public Class1()
        {
            this.a = 1;
            Console.WriteLine($"Class1() 호출");
        }

        public Class1(int b)
        {
            this.a = 1;
            this.b = b;
            Console.WriteLine($"Class1({b}) 호출");
        }

        public Class1(int b, int c)
        {
            this.a = 1;
            this.b = b;
            this.c = c;
            Console.WriteLine($"Class1({b}, {c}) 호출");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a:{a}, b:{b}, c:{c}\n");
        }
    }
}
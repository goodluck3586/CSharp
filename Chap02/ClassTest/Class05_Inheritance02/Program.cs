using System;

namespace Class05_Inheritance02
{
    class Program
    {
        static void Main(string[] args)
        {
            Base a = new Base("A");
            a.BaseMethod();

            Console.WriteLine();

            Derived b = new Derived("B");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}

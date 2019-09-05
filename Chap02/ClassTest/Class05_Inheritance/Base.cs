using System;

namespace Class05_Inheritance
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Base()");
        }
        ~Base()
        {
            Console.WriteLine("~Base()");
        }
    }

    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derived()");
        }
        ~Derived()
        {
            Console.WriteLine("~Derived()");
        }
    }
}


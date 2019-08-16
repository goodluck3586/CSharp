using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Console.WriteLine();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
            
        }
    }
}

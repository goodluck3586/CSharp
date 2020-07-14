using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Class_AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine($"a.value1 : {a.value1}");
            //Console.WriteLine($"a.value2 : {a.value2}");

            B b = new B();
            Console.WriteLine($"b.value1 : {b.GetValue1()}");
            Console.WriteLine($"b.value2 : {b.GetValue2()}");

            var c = new A.C();
            Console.WriteLine($"c.value3 : {c.GetValue3()}");
        }
    }

    class A
    {
        public int value1 = 10;
        protected int value2 = 20;
        private int value3 = 30;

        public class C : A
        {
            public int GetValue3()
            {
                return value3;
            }
        }
    }

    class B : A
    {
        public int GetValue1()
        {
            return value1;
        }

        public int GetValue2()
        {
            return value2;
        }
    }

    
}

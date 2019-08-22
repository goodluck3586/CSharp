using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType00
{
    class Program
    {
        static void Main(string[] args)
        {
            // C#은 강한 형식의 언어이다.
            int a = 5;
            int b = a + 2; //OK

            bool test = true;
            Console.WriteLine(typeof(bool).FullName);
            // Error. Operator '+' cannot be applied to operands of type 'int' and 'bool'.
            //int c = a + test;

            int i = new int();
            Console.WriteLine(i);
            System.Int32 myInt = new System.Int32();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 452p 연습문제 1 */
namespace Exercise19
{
    delegate int MyDeldgate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            MyDeldgate Callback;
            Callback = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(Callback(3,4));

            Callback = delegate (int a, int b)
            {
                return a - b;
            };

            Console.WriteLine(Callback(7,5));
        }
    }
}

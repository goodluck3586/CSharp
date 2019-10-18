using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 익명 메소드(Anonymous Method) : 다시 사용하지 않는 경우 유용 */
namespace Delegate07_AnonymousMethod
{
    class Program
    {
        delegate int Calculate(int a, int b);

        static void Main(string[] args)
        {
            Calculate Calc;
            Calc = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine("3 + 4 : {0}", Calc(3,4));
        }
    }
}

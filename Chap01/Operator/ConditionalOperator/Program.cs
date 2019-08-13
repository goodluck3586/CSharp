using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요 : ");
            int a = int.Parse(Console.ReadLine());
            string result = a % 2 == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2개의 실수를 입력하세요.");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            double d1, d2;
            d1 = double.Parse(s1);
            d2 = double.Parse(s2);

            Console.WriteLine($"{d1} + {d2} = {d1+d2}");
        }
    }
}

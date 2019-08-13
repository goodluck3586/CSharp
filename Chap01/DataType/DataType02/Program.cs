using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType02
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** object는 모든 데이터 형식의 부모 *****/
            object a = 100;
            object b = 3.14;
            object c = true;
            object d = "Hello World";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());

            // 언박싱
            //Console.WriteLine(a+b);  // object 끼리 연산할 수 없음.
            Console.WriteLine("a + b = " + ((int)a + (double)b));  // 언박싱


            /***** 문자열 ↔ 숫자 변환 *****/
            string strNum = "12345";
            int intNum = int.Parse(strNum);

            intNum = 67890;
            strNum = intNum.ToString();
        }
    }
}

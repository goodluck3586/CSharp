using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType01
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** 정수형 데이터 타입 *****/
            int num1 = 100;
            System.Int32 num2 = 200;
            var sum = num1 + num2;  // breakpoint 설정하고 디버깅 모드에서 변수값 확인하기

            Console.WriteLine(num1 + " + " + num2 + " = " + sum);

            // 변수의 데이터 타입 출력
            Console.WriteLine($"num1 type : {num1.GetType()}");
            Console.WriteLine($"num2 type : {num2.GetType()}");
            Console.WriteLine($"sum type : {sum.GetType()}");

            // 정수형 타입의 범위
            Console.WriteLine(System.Int32.MinValue);
            Console.WriteLine(System.Int32.MaxValue);

            Console.WriteLine('\n'); // 줄바꿈


            /***** 실수형 데이터 타입 *****/
            float num3 = 5.2f;
            double num4 = 10.5;
            var sum2 = num3 + num4;

            Console.WriteLine($"{num3} + {num4} = {sum2}");  // 암시적 형변환
            Console.WriteLine((int)num3 + (int)num4);  // 명시적 형변환

            // 변수의 데이터 타입 출력
            Console.WriteLine($"num3 type : {num3.GetType()}");
            Console.WriteLine($"num4 type : {num4.GetType()}");
            Console.WriteLine($"sum2 type : {sum2.GetType()}");

            Console.WriteLine('\n'); // 줄바꿈


            /***** 문자형 데이터 타입 *****/
            char ch = 'A';
            string str = "Hello \nWorld";
         
            Console.WriteLine((int)ch);  // ASCII 코드로 출력
            Console.WriteLine(str);
        }
    }
}

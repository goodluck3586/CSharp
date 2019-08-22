using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 상수, 열거형, Nullable 형식
 */
namespace DataType04
{
    class Program
    {
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat};  // 열거형(같은 범주에 속하는 여러 개의 상수 선언)

        static void Main(string[] args)
        {
            /********** 상수(const) **********/
            const double pi = 3.14;
            //a = 3.141592;  // Error: 상수는 값을 수정할 수 없다.
            Console.WriteLine("{0} ~ {1}", double.MinValue, double.MaxValue);

            Console.WriteLine('\n');


            /********** 열거형(enum) : 명명된 상수 집합 **********/
            // 열거형은 기본 형식이 모든 정수 계열 형식이 명명 된 상수의 집합
            Day today = Day.Mon;
            Console.WriteLine("today: {0}", today);
            Console.WriteLine((int)Day.Sun);
            Console.WriteLine((int)Day.Mon);
            Console.WriteLine((int)Day.Tue);

            // System.Type 개체를 얻는다.
            Console.WriteLine(typeof(int));
            Console.WriteLine(typeof(double));

            Type days = typeof(Day);  //System.Type
            Console.WriteLine(days);

            //Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
            Console.WriteLine("요일을 숫자(일:0, 월:1)로 입력하시오:");
            string input = Console.ReadLine();

            //today 
            switch (Enum.Parse(days, input)){
                case Day.Sun:
                    Console.WriteLine("SunDay");
                    break;
                case Day.Mon:
                    Console.WriteLine("Monday");
                    break;
                case Day.Tue:
                    Console.WriteLine("Tuesday");
                    break;
                case Day.Wed:
                    Console.WriteLine("Wednesday");
                    break;
                case Day.Thu:
                    Console.WriteLine("Thursday");
                    break;
                case Day.Fri:
                    Console.WriteLine("Friday");
                    break;
                case Day.Sat:
                    Console.WriteLine("Saturday");
                    break;
            }

            Console.WriteLine('\n');

            /********* Nullable 형식 *********/
            int? n = null;

            Console.WriteLine(n.HasValue);

            n = 100;
            Console.WriteLine(n.Value);
        }
    }
}

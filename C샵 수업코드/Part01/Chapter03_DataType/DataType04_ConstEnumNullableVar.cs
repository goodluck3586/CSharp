/* 상수, 열거형, Nullable형식, var */
namespace DataType04
{
    class Program
    {
        // 열거형(같은 범주에 속하는 여러 개의 상수 선언), 0부터 순차적으로 값이 부여되나 명시적으로 설정 가능
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat};

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
            Console.WriteLine("today: {0}, {1}", today, (int)today);
            Console.WriteLine("{0}, {0:d}", Day.Sun);
            Console.WriteLine("{0}, {0:d}", Day.Mon);
            Console.WriteLine("{0}, {0:d}", Day.Tue);
            Console.WriteLine(Day.Mon.GetType());

            //Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
            Console.Write("요일을 숫자(일:0, 월:1)로 입력하시오:");
            string input = Console.ReadLine();

            // 입력한 숫자에 해당하는 요일 출력 : 어떤 숫자가 어떤 요일인지 알아야 한다.
            WhatDayUsingNumber(int.Parse(input));

            // Enum 열거형을 사용하여 요일 출력
            WhatDayUsingEnum((Day)Convert.ToInt32(input));  // 정수를 열거형 타입으로 캐스트 변환 가능

            Console.WriteLine('\n');


            /********* Nullable 형식 *********/
            int? n = null;

            Console.WriteLine(n.HasValue);

            n = 100;
            Console.WriteLine(n.Value);
            Console.WriteLine('\n');


            /********** var **********/
            var a = 3;
            var b = "hello";
            var c = pi;

            Console.WriteLine("a: {0}", a.GetType());
            Console.WriteLine("b: {0}", b.GetType());
            Console.WriteLine("c: {0}", c.GetType());
        }

        static void WhatDayUsingNumber(int i)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine("SunDay");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }

        static void WhatDayUsingEnum(Day day)
        {
            switch (day)
            {
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
        }
    }
}
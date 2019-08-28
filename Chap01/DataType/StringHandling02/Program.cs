using System;


namespace StringHandling02
{
    class Program
    {
        static void Main(string[] args)
        {
            /********** string literal **********/
            //Initialize with a regular string literal.
            string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

            // Initialize with a verbatim string literal.
            string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

            char[] letters = { 'A', 'B', 'C' };
            string alphabet = new string(letters);
            Console.WriteLine(alphabet);
            Console.WriteLine();


            /********** 문자열 개체의 불변성 **********/
            string s1 = "Hello ";
            string s2 = s1;
            s1 += "World";

            System.Console.WriteLine(s2);  //Output: Hello
            Console.WriteLine();


            /********** 형식의 서식 지정 **********/
            // https://docs.microsoft.com/ko-kr/dotnet/standard/base-types/formatting-types?view=netframework-4.8

            // 문자열 서식
            string result = string.Format("{0}DEF", "ABC");
            Console.WriteLine(result);
            result = string.Format("{0, -10}DEF", "ABC");
            Console.WriteLine(result);
            result = string.Format("{0, 10}DEF", "ABC");
            Console.WriteLine(result);

            // 숫자 서식
            Console.WriteLine(
            "(C) Currency: . . . . . . . . {0:C}\n" +
            "(D) Decimal:. . . . . . . . . {0:D}\n" +
            "(E) Scientific: . . . . . . . {1:E}\n" +
            "(F) Fixed point:. . . . . . . {1:F}\n" +
            "(G) General:. . . . . . . . . {0:G}\n" +
            "    (default):. . . . . . . . {0} (default = 'G')\n" +
            "(N) Number: . . . . . . . . . {0:N}\n" +
            "(P) Percent:. . . . . . . . . {1:P}\n" +
            "(R) Round-trip: . . . . . . . {1:R}\n" +
            "(X) Hexadecimal:. . . . . . . {0:X}\n",
            -123, -123.45f);

            // 날짜 서식
            Console.WriteLine("{0:d}", DateTime.Now);
            Console.WriteLine("{0:D}", DateTime.Now);
            Console.WriteLine("{0:f}", DateTime.Now);
            Console.WriteLine("{0:F}", DateTime.Now);

        }
    }
}

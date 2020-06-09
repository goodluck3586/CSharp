 /* 값 형식 데이터 타입 */
namespace DataType01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*************** C#은 강한 형식의 언어이다. ***************/
            int a = 5;
            int b = a + 2; //OK

            bool test = true;
            //int c = a + test;  // 타입 에러


            /*************** 값 형식 초기화 ***************/      
            int int1, int2;
            //Console.WriteLine(int1);  // Error: C#의 지역 변수는 사용하기 전에 초기화해야 한다.

            // 초기화
            int1 = 0;          // 리터럴을 사용하여 초기화할 수 있다.
            int2 = new int();  // new 연산자를 사용하면 특정 형식의 매개 변수 없는 생성자가 호출되고 변수에 기본값이 할당된다.
                                
            // 선언과 동시에 초기화
            int int3 = 0;
            int int4 = new int();


            /*************** bool ***************/        
            bool bool1 = new bool();  // bool은 System 네임스페이스에 미리 정의된 구조체 형식(System.Boolean)의 별칭
            System.Boolean bool2 = new System.Boolean();  
            Console.WriteLine("bool 변수의 기본값: " + bool1);
            Console.WriteLine("bool1 변수의 타입: " + bool1.GetType());
            Console.WriteLine("bool2 변수의 타입: " + bool2.GetType());

            Console.WriteLine('\n');  // 줄바꿈
            // C#에서의 bool은 int형과 호환되지 않는다.

            /*************** 정수 숫자 형식 ***************/      
            int num1 = 100;                // int는 System 네임스페이스에 미리 정의된 구조체 형식(System.Int32)의 별칭
            System.Int32 num2 = 0x2A;      // 정수 리터럴은 10진수, 16진수(0x), 2진수(0b)로 지정할 수 있다.
            int sum = num1 + num2;  // breakpoint 설정하고 디버깅 모드에서 변수값 확인하기

            Console.WriteLine(num1 + " + " + num2 + " = " + sum);

            // 정수형 타입의 범위: 해당 형식의 최솟값과 최댓값을 제공하는 MinValue 및 MaxValue 상수가 있다.
            Console.WriteLine("int 타입의 범위: {0} ~ {1}", int.MinValue, System.Int32.MaxValue);

            // 표준 숫자 형식 문자열
            Console.WriteLine("{0:d}", 1234);
            Console.WriteLine("{0:d6}", 1234);
            Console.WriteLine("{0,6:d}", 1234);
            Console.WriteLine("{0,6:d6}", 1234);

            Console.WriteLine('\n'); // 줄바꿈


            /*************** 부동 소수점 숫자 형식 ***************/
            float num3 = 3.141592653589793238462643383279f;
            double num4 = 3.141592653589793238462643383279;
            decimal num5 = 3.141592653589793238462643383279m;  // decimal 형식은 float 및 double보다 정밀도가 높고 범위가 작으므로 재무 및 통화 계산에 적합

            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);

            // 표준 숫자 형식 문자열  
            Console.WriteLine("{0:f2}", num4);
            Console.WriteLine("{0:f3}", num4);
            Console.WriteLine("{0:f4}", num4);

            // 부동 소수점 형식의 데이터 타입 출력
            Console.WriteLine($"float type : {num3.GetType()}");
            Console.WriteLine($"double type : {num4.GetType()}");
            Console.WriteLine($"decimal type : {num5.GetType()}");

            Console.WriteLine('\n'); // 줄바꿈


            /*************** char(유니코드 16비트 문자) ***************/
            char ch1 = 'A';
            char ch2 = (char)97;  //char는 ushort, int, uint, double 또는 decimal로 암시적으로 변환될 수 있

            Console.WriteLine(ch1);
            Console.WriteLine((int)ch1);  // ASCII 코드로 출력
            Console.WriteLine(ch2);

            // System.Char 메서드
            Console.WriteLine(ch1.Equals('A'));				// Output: "True"
            Console.WriteLine(Char.IsLower('A'));			// Output: "False"
            Console.WriteLine(Char.ToLower('A'));			// Output: "a"
        }
    }
}

// 값 형식 초기화 : https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/value-types
// 기본 제공 형식: https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/built-in-types-table
// 기본값 표: https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/default-values-table
// 불 : // https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/bool
// 정수 타입 : https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
// 표준 숫자형식 문자열 : https://docs.microsoft.com/ko-kr/dotnet/standard/base-types/standard-numeric-format-strings
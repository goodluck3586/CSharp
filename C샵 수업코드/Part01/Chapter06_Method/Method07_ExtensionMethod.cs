using System;

// 확장메서드(Extension Method)는 특수한 종류의 static 메서드
// 확장메서드는 클래스, 구조체, 인터페이스 등에 적용될 수 있다.
// 확장메서드를 사용하면 클래스를 직접 변경하지 않고도, 
// 클래스 외부에서 (확장)메서드를 정의함으로 해서 마치 그 클래스의 기능을 확장한 인스턴스 메서드를 추가한 것 같은 효과를 낼 수 있다.
namespace Ex07_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "this Is A TeSt ZZZ";
            double num = 0.5;

            Console.WriteLine(str.Capitalize());              // 첫 문자만 대문자, 나머지는 소문자로 변환하여 출력
            Console.WriteLine(str.CountOfCapitalLetter());    // 대문자의 갯수로 변환하여 출력
            Console.WriteLine(num.GetPersentValue());           // 실수를 백분률 문자열로 변환하여 출력
        }
    }

    // 확장 메소드와 클래스 정의
    static class MyUtil                                         // 확장메서드는 static class 안에 static method로 정의
    {
                                                                // 첫번째 파라미터로 항상 클래스명(혹은 타입)을 지정(확장메서드가 사용될 클래스 타입을 지정)
        public static string Capitalize(this string str)        // 첫번째 매개변수는 이 메소드를 활용할 수 있는 타입 결정
        {
            string firstLetter = str[0].ToString().ToUpper();   // 첫 문자를 대문자로 저장
            return firstLetter + str.Substring(1).ToLower();    // 첫 대문자와 나머지를 소문자로 연결하여 리턴
        }

        public static int CountOfCapitalLetter(this string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c >= 'A' && c <= 'Z')
                    count++;
            }
            return count;
        }

        public static string GetPersentValue(this double num)   // 매개변수 타입이 int이기 때문에 int형 객체에서 사용 가능한 메소드
        {
            return $"{num * 100}%";
        }
    }
}

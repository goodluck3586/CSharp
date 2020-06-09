/* 문자열 조작 */
namespace StringHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            Console.WriteLine(greeting+'\n');

            #region 문자열 찾기
            // IndexOf() : 찾는 문자열의 위치
            Console.WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            Console.WriteLine("IndexOf 'o' : {0}", greeting.IndexOf("o"));

            //LastIndexOf() : 찾는 문자열의 위치(뒤에서 부터)
            Console.WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
            Console.WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf("o"));

            // StartWith() : 지정된 물자열로 시작하는지 판단
            Console.WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
            Console.WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));

            // EndsWith() : 지정된 물자열로 끝나는지 판단
            Console.WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
            Console.WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));

            // Contains() : 지정된 물자열을 포함하는지 판단
            Console.WriteLine("Contains 'Good' : {0}", greeting.Contains("Good"));
            Console.WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));

            // Replace() : 지정된 문자열을 다른 문자열로 수정한 문자열 반환
            Console.WriteLine("Replace 'Morning' with 'Evening' : {0}", greeting.Replace("Morning", "Evening"));
            Console.WriteLine();
            #endregion

            #region 문자열 변형하기
            // ToLower(), ToUpper()
            Console.WriteLine(greeting.ToLower());
            Console.WriteLine(greeting.ToUpper());

            // Insert(), Remove()
            Console.WriteLine("Happy Day!".Insert(5, " Sunny"));
            Console.WriteLine("I Don't love you.".Remove(2, 6));

            // Trim
            string str = " No Space ";
            Console.WriteLine($"'{str.Trim()}'");
            Console.WriteLine($"'{str.TrimStart()}'");
            Console.WriteLine($"'{str.TrimEnd()}'");
            Console.WriteLine();
            #endregion

            #region 문자열 분할하기
            // Substring() : 문자열 추출
            string words = "이것은 구두점과 \t탭 문자가 포함된 단어들 입니다.";
            Console.WriteLine(words);
            Console.WriteLine(words.Substring(0, 3));  // "이것은"
            Console.WriteLine(words.Substring(20));  // "단어들 입니다."
            Console.WriteLine();

            // Split() : 문자열을 지정된 기준으로 분리한 배열 반환
            string[] s1 = words.Split(new Char[] {' ', ',', '.', ':', '\t'});
            Console.WriteLine($"s1.Length : {s1.Length}");

            foreach(string s in s1)
            {
                Console.WriteLine(s);
            }

            foreach(string s in s1)
            {
                if(s.Trim() != "")
                    Console.Write(s+' ');
            }
            Console.WriteLine();

            string[] s2 = words.Split(new Char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"s2.Length : {s2.Length}");

            foreach (string s in s2)
            {
                Console.WriteLine(s);
            }

            foreach (string s in s2)
            {
                Console.Write(s + ' ');
            }
            Console.WriteLine();
            #endregion

            #region string literal
            //Initialize with a regular string literal.
            string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

            // Initialize with a verbatim string literal.
            string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

            char[] letters = { 'A', 'B', 'C' };
            string alphabet = new string(letters);
            Console.WriteLine(alphabet);
            Console.WriteLine();
            #endregion

            #region 문자열 개체의 불변성 
            string str1 = "Hello ";
            string str2 = str1;
            str1 += "World";

            System.Console.WriteLine(s2);  //Output: Hello
            Console.WriteLine();
            #endregion

            #region 서식 지정
            // 문자열 서식
            string result = string.Format("{0}DEF", "ABC");
            Console.WriteLine(result);
            result = string.Format("{0, -10}DEF", "ABC");
            Console.WriteLine(result);
            result = string.Format("{0, 10}DEF", "ABC");
            Console.WriteLine(result);

            // 날짜 서식
            DateTime dt = new DateTime(2019, 8, 28, 13, 30, 22);
            Console.WriteLine("{0}", dt);
            Console.WriteLine("{0:d}", DateTime.Now);
            Console.WriteLine("{0:D}", DateTime.Now);
            Console.WriteLine("{0:f}", DateTime.Now);
            Console.WriteLine("{0:F}", DateTime.Now);
            #endregion
        }
    }
}

/********** 형식의 서식 지정 **********/
// https://docs.microsoft.com/ko-kr/dotnet/standard/base-types/formatting-types?view=netframework-4.8
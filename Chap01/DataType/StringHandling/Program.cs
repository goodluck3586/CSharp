using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 문자열 조작
 */
namespace StringHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            Console.WriteLine(greeting);
            Console.WriteLine();

            /********** 문자열 찾기 **********/
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

            /********** 문자열 변형하기 **********/
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

            /********** 문자열 분할하기 **********/
            // Substring() : 문자열 추출
            string words = "This is a list of words, with: a bit of punctuation" + 
                "\tand a tab character.";
            Console.WriteLine(words);
            Console.WriteLine(words.Substring(0, 5));  // "This"
            Console.WriteLine(words.Substring(30));  // "Morning"
            Console.WriteLine();

            // Split() : 문자열을 지정된 기준으로 분리한 배열 반환
            string[] split1 = words.Split(new Char[] {' ', ',', '.', ':', '\t'});
            Console.WriteLine($"split1.Length : {split1.Length}");
            foreach(string s in split1)
            {
                if(s.Trim() != "")
                    Console.Write(s+' ');
            }
            Console.WriteLine();

            string[] split2 = words.Split(new Char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"split2.Length : {split2.Length}");
            foreach (string s in split2)
            {
                Console.Write(s + ' ');
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 연습문제 03 (문자를 하나 입력받아 알파벳인지 아닌지를 출력) */
namespace Ex03_CheckAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = 'a';
            Console.WriteLine((int)c);

            Console.WriteLine("Enter a character : ");
            c = (char)Console.Read();

            if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
            {
                Console.WriteLine($"{c}는 알파벳 입니다.");
            }
            else
            {
                Console.WriteLine($"{c}는 알파벳이 아닙니다.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Check Alphabet
 */
namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("Enter a character : ");
            c = char.Parse(Console.ReadLine());

            if(c>='a' && c<='z' || c>='A' && c <= 'Z')
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_CheckAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character");
            char a = (char)Console.Read();

            if(a>='a' && a<='z' || a>='A' && a <= 'Z')
            {
                Console.WriteLine("알파벳 입니다.");
            }
            else
            {
                Console.WriteLine("알파벳이 아닙니다.");
            }

        }
    }
}

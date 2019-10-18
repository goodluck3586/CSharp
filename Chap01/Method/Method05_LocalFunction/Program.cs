using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* LocalFunction */
namespace Method05_LocalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning"));
            Console.WriteLine(ToLowerString("This is C#."));
        }

        private static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if (arr[i] >= 'A' && arr[i] <= 'Z')  // ASCII값 : A~Z = 65~90, a~z = 97~122
                {
                    return (char)(arr[i] + 32); 
                }
                else
                {
                    return arr[i];
                }
            }

            return new string(arr);
        }
    }
}

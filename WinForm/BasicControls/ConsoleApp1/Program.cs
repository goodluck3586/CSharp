using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        delegate string Concatenate(string[] args);
        static void Main(string[] args)
        {
            Concatenate concat = (string[] arr) =>
            {
                string result = "";
                foreach (var s in arr)
                {
                    result += s;
                }
                return result;
            };
            Console.WriteLine(concat(args));
        }
    }
}

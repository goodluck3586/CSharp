using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* params */
namespace Method04_params
{
    class Program
    {
        static void Main(string[] args)
        {
            // 가변길이 매개변수
            int sum = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"Sum: {sum}");

            Console.WriteLine();

            // 명명된 매개변수
            PrintProfile(name: "박찬호", phone: "010-123-1234");
            PrintProfile("류현진", "010-111-2222");

            // 선택적 매개 변수
            PrintProfile("아이유");  

        }

        private static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }

        static int Sum(params int[] args)
        {
            int sum = 0;
            
            for(int i=0; i<args.Length; i++)
            {
                if(i>0)
                    Console.Write(", ");

                Console.Write(args[i]);
                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }
    }
}

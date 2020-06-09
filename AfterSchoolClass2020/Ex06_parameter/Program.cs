using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 가변길이 매개변수
            Console.WriteLine($"Sum() 실행 결과: {Sum(1, 2, 3, 4, 5)}");
            Console.WriteLine($"Sum() 실행 결과: {Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)}");

            // 명명된 매개변수
            PrintProfile(name: "이동윤", phone: "010-1234-5678");
            PrintProfile(phone: "010-1234-5678", name: "이동윤");
            PrintProfile("이동윤", "010-1234-5678");

            // 선택적 매개변수(매개변수 초기화)
            PrintProfile("아이유");

        }

        private static void PrintProfile(string name, string phone = "전화번호 모름")
        {
            Console.WriteLine($"Name : {name}, Phone : {phone}");
        }

        private static int Sum(params int[] args)
        {
            int sum = 0;
            Console.Write("매개 변수 : ");
            foreach (var item in args)
            {
                sum += item;
                Console.Write(item+" ");
            }
            Console.WriteLine();

            return sum;
        }
    }
}

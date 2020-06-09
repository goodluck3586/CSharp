using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 다양한 매개변수(params, 명명된 매개변수, 선택적 매개변수) */
namespace Ex06_parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 가변길이 매개변수
            Console.WriteLine($"Sum()함수 실행 결과: {Sum(1, 2, 3, 4, 5)}");
            Console.WriteLine($"Sum()함수 실행 결과: {Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)}");
            Console.WriteLine();

            // 명명된 매개변수
            Console.WriteLine("*** 명명된 매개변수 ***");
            PrintProfile("류현진", "010-111-2222");
            PrintProfile(name: "박찬호", phone: "010-123-1234");
            PrintProfile(phone: "010-123-4567", name: "홍길동");
            Console.WriteLine();

            // 선택적 매개 변수
            Console.WriteLine("*** 선택적 매개변수 ***");
            PrintProfile("아이유");
        }

        static int Sum(params int[] args)
        {
            int sum = 0;

            Console.Write("매개 변수 : ");
            foreach(int i in args)
            {
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine();

            return sum;
        }

        private static void PrintProfile(string name, string phone = "전화번호 모름")
        {
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }
    }
}

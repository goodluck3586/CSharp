using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_Parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            // 소수를 판별할 숫자들의 범위
            long startNum = 2, endNum = 100000;

            Console.WriteLine("Started...");
            DateTime startTime = DateTime.Now;  // 시작 시간
            List<long> found = new List<long>();  // 찾은 소수를 저장할 리스트

            // 지정된 범위의 숫자로 함수를 수행하는데 적합한 스레드를 알아서 생성해서 수행함.
            Parallel.For(startNum, endNum, (long i) =>
            {
                lock (found)
                {
                    if (IsPrime(i))
                        found.Add(i); 
                }
            });

            DateTime endTime = DateTime.Now;
            TimeSpan elapsed = endTime - startTime;  // TimeSpan 두 날짜 간의 시간 간격
            Console.WriteLine($"소수 개수: {found.Count}");
            Console.WriteLine($"실행 시간 : {elapsed}");
        }

        // 소수 판별 메소드
        private static bool IsPrime(long number)
        {
            if (number == 2)
                return true;

            for (int i = 2; i <= number/2; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
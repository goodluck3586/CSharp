using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 649p 예제 */
// 소수를 찾는 과정을 여러 비동기 작업으로 나누어 처리
namespace Task03_PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // 소수를 판별할 숫자들의 범위
            long startNum = 2, endNum = 1000000;
            int taskCount = 8;

            // Task<TResult>를 위한 반환값을 갖는 메소드를 Func에 담음
            Func<object, List<long>> FindPrimeFunc = (objRange) =>
            {
                long[] range = (long[])objRange;  // 매개변수 unboxing(소수 탐색을 수행할 범위 저장 배열) 
                List<long> found = new List<long>();  // 찾은 소수를 저장할 리스트

                // 소수를 찾으면 found 리스트에 추가
                for (long i = range[0]; i < range[1]; i++)
                {
                    if (IsPrime(i))
                        found.Add(i);
                }
                return found;  // 소수가 저장된 List<long> 반환
            };

            // taskCount 숫자만큼 Task 인스턴스를 저장할 배열 생성
            Task<List<long>>[] tasks = new Task<List<long>>[taskCount]; // 반환값을 갖는 Task 배열

            // Task별 작업범위 지정
            long currentStartNum = startNum;
            long currentEndNum = endNum / tasks.Length;

            // taskCount 숫자만큼 Task 인스턴스 생성(인스턴스마다 작업 범위 지정)
            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine($"Task[{i}] : {currentStartNum} ~ {currentEndNum}");
                tasks[i] = new Task<List<long>>(FindPrimeFunc, new long[] { currentStartNum, currentEndNum });
                currentStartNum = currentEndNum + 1;  // 현재 검사한 범위보다 1큰 수를 currentStartNum으로 지정

                if (tasks.Length == 2)  // Task의 개수가 2개라면 currentEndNum을 검사할 범위의 마지막 숫자로 지정
                    currentEndNum = endNum;
                else
                    currentEndNum = currentEndNum + (endNum / tasks.Length);  // Task의 개수가 2개 이상이라면 currentEndNum을 등분된 크기만큼 더한 숫자로 지정
            }

            Console.WriteLine("Started...");
            DateTime startTime = DateTime.Now;  // 시작 시간

            // Task[] 배열의 task 모두 실행
            foreach (var task in tasks)
                task.Start();

            List<long> total = new List<long>();

            // 모든 테스트가 끝나면 total List에 결과 붙이기
            foreach (var task in tasks)
            {
                task.Wait();
                total.AddRange(task.Result);
            }
            DateTime endTime = DateTime.Now;
            TimeSpan elapsed = endTime - startTime;  // TimeSpan 두 날짜 간의 시간 간격
            Console.WriteLine($"소수 개수: {total.Count}");
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

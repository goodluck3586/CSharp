using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 표준 쿼리 연산자: 사용자는 쿼리 구문 대신 메서드 구문을 사용하여 연산자를 직접 호출할 수 있다. */
namespace LINQ06_QueryMethod
{
    class Program
    {
        /* 랜덤 숫자 생성 메서드 */
        static int[] RandomNumGenerator(int length)
        {
            int[] numbers = new int[length];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = random.Next(1, 100);
            return numbers;
        }

        static void Main(string[] args)
        {
            // 1. 데이터 소스(자연수 20개가 저장된 배열)
            int[] numbers = RandomNumGenerator(20);  // 랜덤 정수 배열 준비

            #region Query 구문 사용
            // 2. 쿼리 만들기(짝수만 오름차순으로 남기는 쿼리)
            var numList1 = from n in numbers  // n(범위 변수), numbers(데이터 소스)
                          where n % 2 == 0   // 식이 true인 요소만 반환
                          orderby n
                          select n;

            // 3. 쿼리 실행(결과 출력)
            Console.WriteLine("---짝수만 추출하여 저장한 리스트---");
            foreach (var item in numList1)
                Console.Write($"{item} ");
            Console.WriteLine('\n');
            #endregion

            #region Method 구문 사용
            // 2. 메서드로 쿼리 만들기
            var numList2 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);

            // 3. 쿼리 실행(결과 출력)
            Console.WriteLine("---짝수만 추출하여 저장한 리스트---");
            foreach (var item in numList2)
                Console.Write($"{item} ");
            Console.WriteLine('\n');
            #endregion
        }
    }
}

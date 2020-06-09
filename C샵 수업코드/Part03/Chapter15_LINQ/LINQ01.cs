/* LINQ(Language Integrated Query) */
/* Collections를 대상으로 쿼리 수행 */
namespace LINQ01
{
    class Program
    {
        /* 랜덤 숫자 생성 메서드 */
        static int[] GenerateRandomIntegerNumbers(int length)
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
            int[] numbers = GenerateRandomIntegerNumbers(20);  // 랜덤 정수 배열 준비

            #region LINQ를 사용하지 않는 경우
            PrintArray(numbers);  // 초기 상태 출력
            {
                List<int> numList = new List<int>();  // 1. 짝수만 저장할 리스트 준비

                // 2. numbers 배열에서 짝수만 추출하여 numList에 저장
                foreach (var item in numbers)
                    if (item % 2 == 0)
                        numList.Add(item);

                // 3. 오름차순 정렬
                numList.Sort();

                // 4. numList의 결과 출력
                Console.WriteLine("---짝수만 추출하여 저장한 리스트---");
                foreach (var item in numList)
                    Console.Write($"{item} ");
                Console.WriteLine('\n');
            } 
            #endregion

            #region LINQ를 사용한 경우
            PrintArray(numbers);
            {
                // 2. 쿼리 만들기(짝수만 오름차순으로 남기는 쿼리)
                var numList = from n in numbers  // n(범위 변수), numbers(데이터 소스)
                             where n % 2 == 0   // 식이 true인 요소만 반환
                             orderby n
                             select n;

                // 3. 쿼리 실행(결과 출력)
                Console.WriteLine("---짝수만 추출하여 저장한 리스트---");
                foreach (var item in numList)
                    Console.Write($"{item} ");
                Console.WriteLine('\n');
            }
            #endregion


            #region where에서 논리 연산자 사용(2와 3으로 나누어지는 수만 남김)
            // 2. 쿼리 만들기(2, 3의 배수)
            var numList2 = from n in numbers  // n(범위 변수), numbers(데이터 소스)
                      where n % 2 == 0 && n % 3 == 0   // && 및 || 연산 사용 가능
                      orderby n
                      select n;

            // 3. 쿼리 실행(결과 출력)
            PrintLINQList(numList2);
            #endregion
        }
        
        /* 배열 출력 메소드 */
        static void PrintArray(int[] arr)
        {
            Console.WriteLine("--- 초기 상태 배열 ---");
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        /* LINQ 결과 컬렉션 출력 */
        static void PrintLINQList(IOrderedEnumerable<int> list)
        {
            Console.WriteLine("--- 2와 3의 배수만 남긴 리스트 ---");
            foreach (var item in list)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
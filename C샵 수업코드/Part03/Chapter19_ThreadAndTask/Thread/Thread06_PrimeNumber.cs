namespace Thread06_PrimeNum
{
    class NumberRange
    {
        public long startNum { get; set; }
        public long endNum { get; set; }
    }

    class Program
    {
        static List<long> found = new List<long>();  // 찾은 소수를 저장할 리스트

        static void Main(string[] args)
        {
            // 소수를 판별할 숫자들의 범위
            int startNum = 2, endNum = 100000;
            int threadCount = 8;

            NumberRange[] numberRanges = new NumberRange[threadCount];

            Thread[] threads = new Thread[threadCount];
            for (int i = 0; i < threadCount; i++)
            {
                threads[i] = new Thread(FindPrimeNumFunc);
            }

            // Thread별 첫번째 작업범위 지정
            int currentStartNum = startNum;
            int currentEndNum = endNum / threads.Length;

            // threadCount 숫자만큼 Thread 인스턴스의 작업 범위 지정
            for (int i = 0; i < threads.Length; i++)
            {
                Console.WriteLine($"threads[{i}] : {currentStartNum} ~ {currentEndNum}");
                numberRanges[i] = new NumberRange() { startNum = currentStartNum, endNum = currentEndNum };

                // 다음 범위 세팅
                currentStartNum = currentEndNum + 1;  // 현재 검사한 범위보다 1큰 수를 currentStartNum으로 지정

                if (threads.Length == 2)  // Task의 개수가 2개라면 currentEndNum을 검사할 범위의 마지막 숫자로 지정
                    currentEndNum = endNum;
                else
                    currentEndNum = currentEndNum + (endNum / threads.Length);  // Task의 개수가 2개 이상이라면 currentEndNum을 등분된 크기만큼 더한 숫자로 지정  
            }

            Console.WriteLine("Started...");
            DateTime startTime = DateTime.Now;  // 시작 시간

            // Thread[] 배열의 thread 모두 실행
            for (int i = 0; i < threadCount; i++)
            {
                threads[i].Start(numberRanges[i]);
            }

            for (int i = 0; i < threadCount; i++)
            {
                threads[i].Join();
            }

            DateTime endTime = DateTime.Now;
            TimeSpan elapsed = endTime - startTime;  // TimeSpan 두 날짜 간의 시간 간격
            Console.WriteLine($"소수 개수: {found.Count}");
            Console.WriteLine($"실행 시간 : {elapsed}");
        }

        private static void FindPrimeNumFunc(object numRange)
        {
            NumberRange range = numRange as NumberRange;
            Console.WriteLine($"{range.startNum} ~ {range.endNum} 스레드 함수 실행");

            // 소수를 찾으면 found 리스트에 추가
            for (long i = range.startNum; i <= range.endNum; i++)
            {
                lock (found)
                {
                    if (IsPrime(i))
                        found.Add(i);
                }
            }
            Console.WriteLine($"{range.startNum} ~ {range.endNum} 스레드 함수 종료");
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
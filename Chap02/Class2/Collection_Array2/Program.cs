using System;

/* System.Array 활용 */
namespace Collection_Array2
{
    class Program
    {
        private static bool CheckPassed(int score)
        {
            if (score >= 60) return true;
            else return false;
        }

        private static void Print(int value)
        {
            Console.Write($"{value} ");
        }

        // 배열 출력 메소드
        private static void PrintArray(Array array)
        {
            foreach(var item in array)
                Console.Write($"{item,2} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };
            Console.WriteLine($"int[]의 타입 : {scores.GetType()}");
            Console.WriteLine($"int[]의 부모 타입 : {scores.GetType().BaseType}\n");  // 배열은 System.Array의 파생 클래스임.

            PrintArray(scores);

            // Array 클래스의 주요 메소드와 프로퍼티
            Array.Sort(scores);  // 정렬
            PrintArray(scores);

            Array.ForEach<int>(scores, new Action<int>(Print));  //지정한 배열의 각 요소에서 지정한 동작을 수행
            Console.WriteLine();

            Console.WriteLine($"Number of dimensions : {scores.Rank}"); // 배열의 차원
            int[,] testArray = new int[3,8];
            Console.WriteLine($"Number of dimensions : {testArray.Rank}"); // 배열의 차원

            Console.WriteLine("Binary Search : 81 is at {0}", Array.BinarySearch<int>(scores, 81));  // 이진 탐색
            Console.WriteLine("Linear Search : 81 is at {0}", Array.IndexOf(scores, 81));  // 순차 탐색
            Console.WriteLine("Everyone passed? : {0}", Array.TrueForAll<int>(scores, CheckPassed));

            // 배열에서 조건을 만족하는 첫 번째 index 반환 
            int index = Array.FindIndex<int>(scores, delegate (int score)
            {
                if (score < 60) return true;
                else return false;
            });
            int index2 = Array.FindIndex<int>(scores, CheckPassed);
            Console.WriteLine($"index: {index2}");

            scores[index] = 61;
            Console.WriteLine("Everyone passed? : {0}", Array.TrueForAll<int>(scores, CheckPassed));

            // 배열 크기 재설정
            Console.WriteLine($"Old length of scores : {scores.GetLength(0)}");  //길이를 측정하는 Array의 차원(0부터 시작)
            Array.Resize<int>(ref scores, 10);
            Console.WriteLine($"Old length of scores : {scores.GetLength(0)}");

            // 배열 초기화
            PrintArray(scores);
            Array.Clear(scores, 3, 7);
            PrintArray(scores);

        }
    }
}

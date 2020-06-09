/* 일반화 대리자 : 일반화 메소드 참조 */
namespace Delegate04
{
    delegate int Compare<T>(T a, T b);  // 두 값을 비교한 결과를 숫자로 반환(-1, 0, 1)

    class Program
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T> // 오름차순 정렬 메소드
        {
            return a.CompareTo(b);
        }

        static int DescendCompare<T>(T a, T b) where T : IComparable<T> // 내림차순 정렬 메소드
        {
            return a.CompareTo(b) * -1;
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer) // 배열, 정렬 메소드
        {
            int i, j;
            T temp;
            int count = 0;
            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)  // 1이면
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                    Console.Write($"[단계 {++count,2:d2}] : ");
                    PrintArray(DataSet);
                }
            }
            Console.WriteLine();
        }

        static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = { 25, 23, 12, 9, 7 };

            Console.WriteLine("Sorting ascending...");
            Console.Write($"초기 상태 : ");
            PrintArray(array);
            BubbleSort(array, new Compare<int>(AscendCompare));

            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("Sorting descending...");
            PrintArray(array2);
            BubbleSort(array2, new Compare<int>(DescendCompare));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 432p 예제 */
/* 오름차순, 내림차순 메소드를 델리게이트로 넘기기 */
namespace Delegate03
{
    delegate int Compare(int a, int b);  // 두 값을 비교한 결과를 숫자로 반환(-1, 0, 1)

    class Program
    {
        static int AscendCompare(int a, int b)  // 오름차순 정렬 메소드
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static int DescendCompare(int a, int b)  // 내림차순 정렬 메소드
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static void BubbleSort(int[] DataSet, Compare Comparer)  // 배열, 정렬 메소드
        {
            int i, j, temp;
            int count = 0;
            for (i = 0; i < DataSet.Length-1; i++)
            {
                for (j = 0; j < DataSet.Length-(i+1); j++)
                {
                    if(Comparer(DataSet[j], DataSet[j + 1]) > 0)  // 1이면
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

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = { 25,23,12,9,7 };

            Console.WriteLine("Sorting ascending...");
            Console.Write($"초기 상태 : ");
            PrintArray(array);
            BubbleSort(array, new Compare(AscendCompare));

            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("Sorting descending...");
            PrintArray(array2);
            BubbleSort(array2, new Compare(DescendCompare));
        }
    }
}

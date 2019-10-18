using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 444p 예제 */
namespace Delegate08_AnonymousMethod
{
    delegate int Compare(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbleSort(array, delegate (int a, int b)
            {
                if (a > b) return 1;
                else if (a == b) return 0;
                else return -1;
            });

            PrintArray(array);

            int[] array2 = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting descending...");
            BubbleSort(array2, delegate (int a, int b)
            {
                if (a < b) return 1;
                else if (a == b) return 0;
                else return -1;
            });

            PrintArray(array2);

        }

        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int temp;
            for (int i = 0; i < DataSet.Length - 1; i++)  // n-1번 반복
            {
                for (int j = 0; j < DataSet.Length - ( i + 1 ); j++)  // n-1, n-2, n-3...
                {
                    if (Comparer(DataSet[j], DataSet[j + 1])>0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}

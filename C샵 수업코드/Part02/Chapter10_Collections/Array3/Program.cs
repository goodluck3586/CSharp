/* 2차원 배열 */

class Program
{
  static void Main(string[] args)
  {
    int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
    int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
    int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };

    PrintArr(arr1);
    PrintArr(arr2);
    PrintArr(arr3);
  }

  static void PrintArr(int[,] arr)
  {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"[{i}, {j}] : {arr[i, j]} ");
        }
        Console.WriteLine();
    }
  }
}
/* 가변 배열(다양한 길이의 배열을 요소로 갖는 배열, 배열을 요소로써 접근 가능) */
class Program
{
    static void Main(string[] args)
    {
        int[][] jagged = new int[3][];
        jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
        jagged[1] = new int[] { 10, 20, 30 };
        jagged[2] = new int[] { 100, 200 };

        PrintArr(jagged);

        int[][] jagged2 = new int[2][]
        {
            new int[]{1000,2000},
            new int[4]{6,7,8,9}
        };

        PrintArr(jagged2);
    }

    static void PrintArr(int[][] jagged)
    {
        foreach (int[] arr in jagged)
        {
            Console.Write($"Length({arr.Length}) : ");
            foreach (int e in arr)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
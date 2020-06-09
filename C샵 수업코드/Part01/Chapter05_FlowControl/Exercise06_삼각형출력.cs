class Program
    {
        static void Main(string[] args)
        {
            int height;

            do
            {
                Console.WriteLine("삼각형 높이는?");
            } while (!int.TryParse(Console.ReadLine(), out height));

            for (int i = 0; i < height; i++)
            {
                // 공백 출력
                for (int a = 0; a < height-i-1; a++)
                {
                    Console.Write(" ");
                }

                // 별 출력
                for (int b = 0; b < i*2+1; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
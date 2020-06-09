/* 반복문과 재귀호출로 피보나치 수열 출력하기 */
namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ulong.MaxValue : {0}\n\n", ulong.MaxValue);

            Console.Write("피보나치 수열의 개수는: ");
            int loopCount = int.Parse(Console.ReadLine());

            Console.WriteLine("반복문을 이용한 피보나치 수열");
            for(int i=0; i<=loopCount; i++)
                Console.WriteLine($"FibonacciLoop({i:d3}) : {FibonacciLoop(i),20}");

            Console.WriteLine('\n');

            //Console.WriteLine("재귀호출을 이용한 피보나치 수열");
            //for (int i = 0; i <= loopCount; i++)
            //    Console.WriteLine($"FibonacciLoop({i:d2}) : {FibonacciRecursive(i)}");
        }

        static ulong FibonacciLoop(int loopCount)
        {
            ulong v1=0, v2=1, returnValue=0;
            for(int i=0; i<loopCount; i++)
            {
                returnValue = v2;
                v2 = v1 + v2;
                v1 = returnValue;
            }
            return returnValue;
        }

        static ulong FibonacciRecursive(int n)
        {
            if (n <= 1)
            {
                return (ulong)n;
            }
            else
            {
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
            }
        }
    }
}

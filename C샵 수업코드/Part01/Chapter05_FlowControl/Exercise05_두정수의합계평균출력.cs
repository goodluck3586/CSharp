/* 두 개의 정수 n과 m (n <= m)이 주어지면 [n, m] 범위의 합계와 평균을 출력 */
namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("두 개의 정수를 입력하시오");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("n={0}, m={1}", n, m);

            SumAndAverage(n, m);
        }

        static void SumAndAverage(int n, int m)
        {
            int sum = 0;
            double avg = 0;

            for(int i=n; i<=m; i++)
            {
                sum += i;
            }

            avg = sum / (double)(m-n+1);  
            Console.WriteLine("Sum: {0}, Average: {1}", sum, avg);
        }
    }
}
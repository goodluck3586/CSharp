/* 연습문제 02 (정수를 입력받아 홀수/짝수 출력) */
namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요 : ");
            int a = int.Parse(Console.ReadLine());
            string result = a % 2 == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);
        }
    }
}
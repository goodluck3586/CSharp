using System;

/* 다음과 같은 객체 배열이 주어지면 double 유형의 객체 합계를 반환하는 메서드 SumDoubleOnly를 작성하시오. */
namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] objectArr = new object[] { 8.9, "dog", 6, 'c', null, 15.99, 745, true };
            Console.WriteLine(SumDoubleOnly(objectArr)); // 24.89
        }

        static double SumDoubleOnly(object[] obj)
        {
            double sum = 0.0;
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i] is double)
                {
                    sum += (double)obj[i];
                }
            }
            return sum;
        }
    }
}

using System;

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

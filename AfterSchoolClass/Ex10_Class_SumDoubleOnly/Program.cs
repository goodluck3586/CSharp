using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Class_SumDoubleOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] objArray = new object[] { 8.9, "dog", 6, 'c', null, 15.99, 745, true };
            Console.WriteLine($"double 값 합계 : {SumDoubleOnly(objArray)}"); // 24.89
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

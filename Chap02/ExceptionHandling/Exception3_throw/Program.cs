using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception3_throw
{
    /* 409p 예제 */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int? a = null;
                int b = a ?? throw new ArgumentNullException();
            }catch(ArgumentNullException e)
            {
                Console.WriteLine(e);
            }

            try
            {
                int[] array = new int[] { 1, 2, 3 };
                int index = 4;
                int value = array[index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException()];
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Main( )함수 종료");
        }
    }
}

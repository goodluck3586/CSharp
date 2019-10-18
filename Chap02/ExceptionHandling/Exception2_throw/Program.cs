using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 명시적 예외 던지기 throw */
/* 407p 예제 */
namespace Exception2_throw
{
    class Program
    {
        private static void DoSomething(int arg)
        {
            if (arg < 10)
                Console.WriteLine($"arg : {arg}");
            else
                throw new Exception("arg가 10보다 큽니다.");
        }

        static void Main(string[] args)
        {
            //DoSomething(11);

            try
            {
                DoSomething(1);
                DoSomething(11);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        
    }
}

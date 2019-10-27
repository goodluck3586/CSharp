using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* 여러 스레드가 자원을 공유하는 경우 동기화 문제를 lock으로 해결 */
/* lock 키워드를 사용하여 자원을 한 순간에 하나의 스레드만 차지할 수 있도록 제한한다. */
namespace Thread05_lock
{
    class Program
    {
        static void Main(string[] args)
        {
            NumClass numObj1 = new NumClass();
            NumClass numObj2 = new NumClass();

            unsynchronizedMethod();
            synchronizedMethod();

            // 공유 자원에 대해 스레드의 동기화 처리가 되지 않은 경우
            void unsynchronizedMethod()
            {
                Thread t1 = new Thread(numObj1.IncreaseNum1);
                Thread t2 = new Thread(numObj1.IncreaseNum1);
                t1.Start(numObj1);
                t2.Start(numObj1);

                t1.Join();
                t2.Join();

                Console.WriteLine($"unsynchronizedMethod() 결과 : {numObj1.Number}");
            }

            // lock을 사용하여 공유 자원에 대해 스레드의 동기화 처리가 된 경우
            void synchronizedMethod()
            {
                Thread t1 = new Thread(numObj2.IncreaseNum2);
                Thread t2 = new Thread(numObj2.IncreaseNum2);
                t1.Start(numObj2);
                t2.Start(numObj2);

                t1.Join();
                t2.Join();

                Console.WriteLine($"synchronizedMethod 결과() : {numObj2.Number}");
            }
        }
    }
}

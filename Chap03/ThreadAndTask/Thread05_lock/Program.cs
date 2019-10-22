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
        int number = 0;

        static void Main(string[] args)
        {
            Program p1 = new Program();
            Program p2 = new Program();

            unsynchronizedMethod();
            synchronizedMethod();

            // 공유 자원에 대해 스레드의 동기화 처리가 되지 않은 경우
            void unsynchronizedMethod()
            {
                Thread t1 = new Thread(threadFunc1);
                Thread t2 = new Thread(threadFunc1);
                t1.Start(p1);
                t2.Start(p1);

                t1.Join();
                t2.Join();

                Console.WriteLine($"unsynchronizedMethod() 결과 : {p1.number}");
            }

            // 공유 자원에 대해 스레드의 동기화 처리가 된 경우
            void synchronizedMethod()
            {
                Thread t1 = new Thread(threadFunc2);
                Thread t2 = new Thread(threadFunc2);
                t1.Start(p2);
                t2.Start(p2);

                t1.Join();
                t2.Join();

                Console.WriteLine($"synchronizedMethod 결과() : {p2.number}");
            }
        }

        // 공유 자원에 대해 스레드 동기화 처리가 되지 않은 함수
        private static void threadFunc1(object obj)
        {
            Program p = obj as Program;
            for (int i = 0; i < 100000; i++)   // 숫자가 커질수록 잘못된 예측할 수 없는 결과가 나옴.
            {
                p.number++;
            }

            // 1. 메모리의 힙 영역에서 number 변수에 해당하는 값을 가져온다.
            // 2. 가져온 값에 1을 더한다.
            // 3. 1이 더해진 새로운 값을 메모리의 힙 영역에 저장한다.
        }

        // 공유 자원에 대해 스레드 동기화 처리가 되어 있는 함수
        private static void threadFunc2(object obj)
        {
            Program p = obj as Program;
            for (int i = 0; i < 100000; i++) 
            {
                lock (p)  // 한 순간에 오직 한 개의 스레드만 접근 허용
                {
                    p.number++;
                }
            }
        }
    }
}

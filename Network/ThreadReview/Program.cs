using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* Thread(명령어를 실행하기 위한 스케줄링 단위로 프로세스 내부에서 생성할 수 있다.) */
namespace ThreadReview
{
    class Program
    {
        // 프로그램이 실행되면 메인 스레드는 기본적으로 생성됨.
        static void Main(string[] args)
        {
            Console.WriteLine("*** Main 스레드 시작 ***");

            // *** Sub Thread1 생성
            Thread t_sub1 = new Thread(subThreadFunc1);     // 매개변수는 ThreadStart() 델리게이트가 받는다.
            //t_sub1.IsBackground = true;        //  true이면 Main Thread가 끝나면 끝나고, false이면 Main Thread가 끝나도 계속 실행된다.
            t_sub1.Start();

            // *** Sub Thread2 생성(매개변수가 있는 스레드)
            Thread t_sub2 = new Thread(subThreadFunc2);     // 매개변수는 ParameterizedThreadStart() 델리게이트가 받는다.
            t_sub2.Start(10);    // 인자 전달

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main Thread : {i}");
                Thread.Sleep(1000);               // Thread.Sleep() : Running 상태인 스레드를 지정된 시간만큼 실행 중단(ThreadState.WaitSleepJoin  상태로 변경)
            }

            t_sub1.Join();       // t_sub1 스레드가 종료될 때 까지 현재 스레드 무한 대기.

            // *** Sub Thread2 생성(람다식으로 함수 전달)
            Thread t_sub3 = new Thread((count)=>
            {
                Console.WriteLine("*** SubThread3 시작 ***");
                for (int i = 0; i < (int)count; i++)
                {
                    Console.WriteLine($"Sub Thread3 : {i}");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("*** SubThread3 종료 ***");
            });
            t_sub3.Start(3);
            t_sub3.Join();

            Console.WriteLine("*** Main 스레드 종료 ***");
        }

        private static void subThreadFunc1()
        {
            Console.WriteLine("*** SubThread1 시작 ***");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Sub Thread1 : {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("*** SubThread1 종료 ***");
        }

        private static void subThreadFunc2(object count)    // 스레드 함수는 매개변수를 object 형식으로 받아야 한다.
        {
            Console.WriteLine("*** SubThread2 시작 ***");
            for (int i = 0; i < (int)count; i++)
            {
                Console.WriteLine($"Sub Thread2 : {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("*** SubThread2 종료 ***");
        }
    }
}

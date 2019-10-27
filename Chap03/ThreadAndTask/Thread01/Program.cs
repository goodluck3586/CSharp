using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/* Thread(명령어를 실행하기 위한 스케줄링 단위로 프로세스 내부에서 생성할 수 있다.) */
namespace Thread01
{
    class Program
    {
        // 프로그램이 실행되면 메인 스레드는 기본적으로 생성됨.
        static void Main(string[] args)
        {
            // 스레드의 존재 확인
            Thread thread = Thread.CurrentThread;  // 현재 실행중인 스레드에 접근할 수 있는 정적 속성 제공
            Console.WriteLine(thread.ThreadState);  // Running

            // Thread.Sleep() : Running 상태인 스레드를 지정된 시간만큼 실행 중단(ThreadState.WaitSleepJoin  상태로 변경)
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(1000);
            }

            /* 새로운 스레드 생성 */ 
            Thread t = new Thread(threadFunc);
            //t.IsBackground = true;  // 프로그램 실행 종료에 영향을 주지 않는다.
            t.Start();  // 스레드가 CPU에 의해 선택되어 실행될 수 있는 단계까지 시간이 걸린다.
            //t.Join();  // t 스레드가 종료될 때 까지 다른 스레드 무한 대기

            Console.WriteLine("Main 스레드 종료");
        }

        private static void threadFunc()
        {
            Thread.Sleep(1000);
            Console.WriteLine("threadFunc() 실행");
            Console.WriteLine("Sub 스레드 종료");
        }
    }
}

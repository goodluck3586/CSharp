using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* 615p 예제 : 스레드 중지 */
namespace Thread04_Abort  // Interrupt
{
    class SideTask
    {
        int count;

        public SideTask(int count)
        {
            this.count = count;
        }

        public void KeepAlive()
        {
            try
            {
                while (count > 0)
                {
                    Console.WriteLine($"{count--} left");
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count : 0");
            } 
            catch(ThreadAbortException e)
            {
                Console.WriteLine($"에러 처리: {e.Message}");
            }
            catch(ThreadInterruptedException e)
            {
                Console.WriteLine($"에러 처리: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Clearing resource");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread t = new Thread(task.KeepAlive);

            Console.WriteLine("Starting thread...");
            t.Start();
            Thread.Sleep(100);

            Console.WriteLine("스레드 중지 메소드 실행");
            t.Abort();  // 스레드 취소(종료), 스레드를 죽인다. , Abort() 메소드를 호출하면 CLR은 해당 스레드가 실행 중이던 코드에 ThreadAbortException 예외를 던진다.
            //t.Interrupt();  // 스레드가 Running인 상태를 피해 WaitJoinSleep 상태에 들어가면 ThreadInterruptedException 예외를 던진다.

            Console.WriteLine("Wating until thread stops...");
            t.Join();  // 스레드가 완전히 정지할 때까지 대기한다.

            Console.WriteLine("Finished");
        }
    }
}

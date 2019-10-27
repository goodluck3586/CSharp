using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* async 한정자, await 연산자로 비동기 코드 만들기 
 * async 한정자: 메소드, 이벤트, 태스크, 람다식 등을 수식
 * async 한정자를 사용하는 메소드는 반환 형식이 void, Task, Task<TResult>여야 한다.
 */
 // 656p 예제
namespace Task05_AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("메인 A");
            Console.WriteLine("메인 B");

            DelayFunc();
            MyAsyncMethod(3);

            Console.WriteLine("메인 E");
            Console.WriteLine("메인 F");

            Console.ReadLine();  // 프로그램 종료 방지
        }

        static void DelayFunc()
        {
            Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("DelayFunc() 종료");
            });
        }

        // 비동기 함수
        async static void MyAsyncMethod(int count)
        {
            Console.WriteLine("MyAsyncMethod C");
            Console.WriteLine("MyAsyncMethod D");

            Thread.Sleep(100);
            await Task.Run(async () =>
            {
                for (int i = 0; i <= count; i++)
                {
                    Console.WriteLine($"{i}/{count}");
                    await Task.Delay(100);
                }
            });

            Console.WriteLine("MyAsyncMethod G");
            Console.WriteLine("MyAsyncMethod H");
        }
    }
}

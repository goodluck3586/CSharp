using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/* 매개변수가 있는 스레드 함수 호출 */
namespace Thread03_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 스레드 실행에 하나의 매개변수 전달 */
            Thread t1 = new Thread(threadFunc1);
            t1.Start(5);   // 매개변수 하나를 전달하여 실행되는 스레드

            /* 스레드 실행에 여러 값을 가진 객체 전달 */
            NameCard nameCard = new NameCard("아이유", 28);
            Thread t2 = new Thread(threadFunc2);
            t2.Start(nameCard);
        }

        // 숫자 값을 매개변수를 받아 반복문을 돌리는 메소드
        private static void threadFunc1(object count)
        {
            for (int i = 0; i < (int)count; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"threadFunc1 : {i}");
            }
        }

        // 객체를 매개변수로 받아 출력하는 메소드
        private static void threadFunc2(object obj)
        {
            NameCard nc = (NameCard)obj;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"threadFunc2 : Name {nc.Name}, Age {nc.Age}");
                Thread.Sleep(1000);
            }
        }
    }
}

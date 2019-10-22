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

        // 하나의 값을 매개변수를 받는 메소드
        private static void threadFunc1(object count)
        {
            for (int i = 0; i < (int)count; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"threadFunc : {i}");
            }
        }

        // 객체를 매개변수로 받는 메소드
        private static void threadFunc2(object obj)
        {
            NameCard nc = (NameCard)obj;
            Console.WriteLine($"Name: {nc.Name}, Age: {nc.Age}");
        }
    }

    class NameCard
    {
        public string Name;
        public int Age;

        public NameCard(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}

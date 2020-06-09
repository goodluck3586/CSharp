using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new MyTimer(3);
            t1.OnTime += new Action(TurnOffGas);    // 정식 표현 방법
            t1.OnTime += WakeUp;                    // 약식 표현 방법
            t1.OnTime += Boom;
            //t1.Start();
            
            t1.OnTime();    // 3개의 메소드가 바로 실행되어 버린다. => Event 필요
        }

        // 타이머를 통해 호출할 콜백 메소드
        static void TurnOffGas()
        {
            Console.WriteLine("가스불을 끕니다.");
        }

        static void WakeUp()
        {
            Console.WriteLine("알람을 울립니다.");
        }

        static void Boom()
        {
            Console.WriteLine("폭탄이 터집니다.");
        }
    }
}

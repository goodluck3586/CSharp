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
            t1.OnTime += TurnOffGas;
            t1.Start();

            t1.Start2(5, WakeUp);
        }

        // 타이머를 통해 호출할 콜백 메소드
        static void TurnOffGas()
        {
            Console.WriteLine("가스불을 끕니다.\n");
        }

        static void WakeUp(int a)
        {
            Console.WriteLine("알람을 울립니다.\n");
        }
    }
}

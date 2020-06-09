using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex10_Event
{
    class MyTimer
    {
        private int t;   // 타이머의 동작 시간
        public event Action OnTime;

        public MyTimer(int t)
        {
            this.t = t;
        }

        public void Start()
        {
            for (int i = t; i > 0; i--)
            {
                Console.WriteLine($"{i}초 남았습니다.");
                Thread.Sleep(1000);
            }

            if(OnTime != null)
                OnTime();
        }
    }
}

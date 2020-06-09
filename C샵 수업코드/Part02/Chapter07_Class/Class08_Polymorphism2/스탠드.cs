using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Polymorphism
{
    class 스탠드
    {
        private 전구 b;

        public void Install(전구 light)
        {
            b = light;
        }

        public void On()
        {
            if(b != null)
                b.TurnOn();
            else
                Console.WriteLine("먼저 전구를 설치하세요.");
        }

        public void Off()
        {
            if (b != null)
                b.TurnOff();
            else
                Console.WriteLine("먼저 전구를 설치하세요.");
        }
    }
}

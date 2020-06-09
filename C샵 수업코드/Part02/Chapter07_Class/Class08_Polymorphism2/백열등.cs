using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Polymorphism
{
    class 백열등 : 전구
    {
        public void TurnOn()
        {
            Console.WriteLine("백열등 켜짐");
        }

        public void TurnOff()
        {
            Console.WriteLine("백열등 꺼짐");
        }
    }
}

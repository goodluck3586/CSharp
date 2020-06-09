using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Polymorphism
{
    class 형광등 : 전구
    {
        public void TurnOn()
        {
            Console.WriteLine("형광등 켜짐");
        }

        public void TurnOff()
        {
            Console.WriteLine("형광등 꺼짐");
        }
    }
}

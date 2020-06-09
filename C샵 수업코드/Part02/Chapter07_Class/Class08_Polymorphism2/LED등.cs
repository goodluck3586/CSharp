using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Polymorphism
{
    class LED등 : 전구
    {
        public void TurnOn()
        {
            Console.WriteLine("LED등 켜짐");
        }

        public void TurnOff()
        {
            Console.WriteLine("LED등 꺼짐");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Polymorphism
{
    interface 전구
    {
        void TurnOn();
        void TurnOff();
    }

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

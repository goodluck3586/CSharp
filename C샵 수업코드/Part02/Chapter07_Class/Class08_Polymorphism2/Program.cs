using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new 스탠드();
            var b1 = new 백열등();
            var b2 = new 형광등();
            var b3 = new LED등();

            s1.Install(b1);
            s1.On();
            s1.Off();

            s1.Install(b2);
            s1.On();
            s1.Off();

            s1.Install(b3);
            s1.On();
            s1.Off();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var stand = new 스탠드();
            var light1 = new 백열등();
            var light2 = new 형광등();
            var light3 = new LED등();

            stand.InstallLight(light1);
            stand.On();
            stand.Off();

            stand.InstallLight(new 형광등());
            stand.On();
            stand.Off();

            stand.InstallLight(new LED등());
            stand.On();
            stand.Off();

        }
    }
}

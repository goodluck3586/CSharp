using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04_AccessModifier
{
    class BoilingWater : WaterHeater
    {
        int amountOfWater;

        public BoilingWater()
        {
            Console.WriteLine("BoilingWater 생성자 호출");
            temp = 100;
            amountOfWater = 1000;
        }

        public int AmountOfWater
        {
            get { return amountOfWater; }
            set { amountOfWater = value; }
            //get => amountOfWater;
            //set => amountOfWater = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04_AccessModifier
{
    class WaterHeater
    {
        protected int temp;

        public WaterHeater()
        {
            Console.WriteLine("WaterHeater 생성자 호출");
        }

        public int GetTemp()
        {
            return temp;
        }

        public void SetTemp(int temp)
        {
            if (temp < -5 || temp > 42)
            {
                throw new Exception("Out of temperature range");
            }
            this.temp = temp;
        }

        internal void BoilWater()
        {
            temp += 10;
            Console.WriteLine($"Temp of boiled water : {temp}\n");
        }
    }
}

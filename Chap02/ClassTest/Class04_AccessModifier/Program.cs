using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04_AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterHeater heater = new WaterHeater();
            Console.WriteLine($"temp = {heater.GetTemp()}");

            try
            {
                heater.SetTemp(20);
                heater.BoilWater();

                heater.SetTemp(-20);
                heater.BoilWater();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n");

            BoilingWater boilingWater = new BoilingWater();
            Console.WriteLine($"temp : {boilingWater.GetTemp()}");

            boilingWater.AmountOfWater = 500;  // setter
            Console.WriteLine("끊는 물의 양: " + boilingWater.AmountOfWater);  // getter
            boilingWater.BoilWater();
        }
    }
}

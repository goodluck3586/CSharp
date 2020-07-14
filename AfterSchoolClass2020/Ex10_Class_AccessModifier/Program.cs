using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Class_AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterHeater waterHeater = new WaterHeater();
            Console.WriteLine($"현재 온도는 {waterHeater.GetTemperature()}도 입니다.");
            Console.WriteLine(waterHeater.SetTemperature(20));
            Console.WriteLine(waterHeater.SetTemperature(200));
            Console.WriteLine($"현재 온도는 {waterHeater.GetTemperature()}도 입니다.");
        }
    }
}

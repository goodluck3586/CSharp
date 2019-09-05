using System;

/* 접근 한정자 */
namespace Class04_AccessModifier
{
    /* 온수기: 온도 설정하고, 온도를 알아낼 수 있다. */
    class WaterHeater
    {
        private int temperature;

        public void SetTemperature(int temp)
        {
            if (temp < 0 || temp > 50)
            {
                throw new Exception("에러: 온도가 정상 범위를 벗어남.");
            }
            this.temperature = temp;
            Console.WriteLine($"temperature = {GetTemperature()}");
        }

        public int GetTemperature()
        {
            return temperature;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WaterHeater heater = new WaterHeater();
            Console.WriteLine($"temperature = {heater.GetTemperature()}");

            //heater.SetTemperature(20);
            //heater.SetTemperature(100);

            try
            {
                heater.SetTemperature(20);
                heater.SetTemperature(100);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

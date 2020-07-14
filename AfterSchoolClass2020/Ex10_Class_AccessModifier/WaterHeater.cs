using System;

namespace Ex10_Class_AccessModifier
{
    class WaterHeater
    {
        private int temperature;

        public String SetTemperature(int temp)
        {
            if(temp<0 || temp > 50)
            {
                return $"에러 온도가 {temp}도로 정상 범위를 벗어남";
            }
            temperature = temp;
            return $"온도가 {temp}도로 설정됨.";
        }

        public int GetTemperature()
        {
            return temperature;
        }

    }
}
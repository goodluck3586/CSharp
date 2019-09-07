using System;

namespace Class01_interface2
{
    /* 인터페이스는 추상 멤버만 갖는 추상 기본 클래스와 같*/
    interface ILogger  // 규칙에 따라 인터페이스 이름은 대문자 I로 시작
    {
        void WriteLog(string log);
    }

    // 인터페이스를 구현하는 클래스는 인터페이스 정의에서 지정된  멤버를 구현해야 한다. 
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}" + '\n');
        }
    }

    class ClimateMonitor
    {
        ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Console.Write("온도를 입력해주세요 : ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                {
                    break;
                }

                logger.WriteLog("현재 온도 : " + temperature);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());
            monitor.start();
        }
    }



}

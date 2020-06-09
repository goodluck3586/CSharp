using System;

namespace Class01_interface1
{
    /* 인터페이스는 추상 멤버만 갖는 추상 기본 클래스와 같다. */
    interface ILogger  // 규칙에 따라 인터페이스 이름은 대문자 I로 시작
    {
        void WriteLog(string log);
    }

    // 인터페이스를 구현하는 클래스는 인터페이스 정의에서 지정된  멤버를 구현해야 한다. 
    class ConsoleLogger : ILogger
    {
        static void Main(string[] args)
        {
            // 인터페이스는 인스턴스는 못 만들지만, 부모 참조변수와 같은 역할을 할 수 있다.
            // 파생 클래스는 부모 클래스와 같은 형식으로 간주될 수 있다.
            ILogger logger = new ConsoleLogger(); 
            logger.WriteLog("Hello World!");

            if(logger is ConsoleLogger)
            {
                ConsoleLogger cl = logger as ConsoleLogger;
                cl.DerivedMethod();
            }
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }

        public void DerivedMethod()
        {
            Console.WriteLine("DerivedMethod()");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            ILogger logger = new ConsoleLogger(); // 인터페이스는 인스턴스는 못 만들지만, 참조는 만들 수 있다.

            logger.WriteLog("Hello World!");
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }
}

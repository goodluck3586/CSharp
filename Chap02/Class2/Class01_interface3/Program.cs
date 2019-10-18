using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class01_interface3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 콘솔에 로그 출력
            ClimateMonitor consoleMonitor = new ClimateMonitor(new ConsoleLogger());
            consoleMonitor.start();

            // 파일에 로그 출력
            ClimateMonitor fileMonitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            fileMonitor.start();
        }
    }
}

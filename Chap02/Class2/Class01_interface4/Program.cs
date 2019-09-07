using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class01_interface4
{
    class Program
    {
        static void Main(string[] args)
        {
            IFomattableLogger logger = new ConsoleLogger();
            logger.WriteLog("The world is not flat");
            logger.WriteLog("{0} + {1} = {2}", 1, 2, 3);
        }
    }
}

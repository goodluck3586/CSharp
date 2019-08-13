using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dat1 = new DateTime();
            // The following method call displays 1/1/0001 12:00:00 AM.
            Console.WriteLine(dat1.ToString(System.Globalization.CultureInfo.InvariantCulture));
            // The following method call displays True.
            Console.WriteLine(dat1.Equals(DateTime.MinValue));
        }
    }
}

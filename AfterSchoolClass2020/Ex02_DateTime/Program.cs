using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime;
            dateTime = new DateTime(2020, 6, 9, 17, 30, 25);

            Console.WriteLine(dateTime.ToString());
            Console.WriteLine(dateTime.Hour);

            dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString());
            Console.WriteLine(dateTime.Hour);

        }
    }
}

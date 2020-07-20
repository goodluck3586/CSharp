using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21_Property
{
    class BirthdayInfo
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { 
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            } 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo() { Name = "아이유", Birthday = new DateTime(1993, 6, 28) };

            Console.WriteLine($"Name: {birth.Name}");
            Console.WriteLine($"Birthday: {birth.Birthday}");
            Console.WriteLine($"Age: {birth.Age}");
        }
    }
}

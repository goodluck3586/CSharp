using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20_Property
{
    class NameCard1
    {
        private string name, phoneNumber;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }

    class NameCard2
    {
        public string Name { get; set; } = "Unknown";
        public string PhoneNumber { get; set; } = "010-0000-0000";
    }

    class Program
    {
        static void Main(string[] args)
        {
            NameCard1 nc1 = new NameCard1();
            nc1.Name = "아이유";
            nc1.PhoneNumber = "010-4444-4444";

            NameCard2 nc2 = new NameCard2();
            nc2.Name = "박보검";
            nc2.PhoneNumber = "010-7777-7777";

            NameCard2 nc3 = new NameCard2() { Name = "소마고", PhoneNumber = "062-949-6800" };
        }
    }
}

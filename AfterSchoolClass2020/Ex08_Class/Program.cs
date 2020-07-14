using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.printField();

            Class1 class2 = new Class1(2);
            class2.printField();

            Class1 class3 = new Class1(2, 3);
            class3.printField();
        }
    }
}

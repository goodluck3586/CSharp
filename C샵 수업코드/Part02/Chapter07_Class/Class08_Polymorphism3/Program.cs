using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Polymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            var f1 = new 인어();
            var f2 = new 상어();

            Dosomething(f1);
            Dosomething(f2);
        }

        private static void Dosomething(물고기 f)
        {
            f.수중호흡하다();

            //if(f is 인어)
            //    ((인어)f).말하다();

            var m = f as 인어;
            if (m != null)
                m.말하다();
        }
    }
}

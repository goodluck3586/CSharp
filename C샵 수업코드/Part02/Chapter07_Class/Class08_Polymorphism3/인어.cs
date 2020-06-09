using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Polymorphism2
{
    class 인어 : 사람, 물고기
    {
        public override void 말하다()
        {
            Console.WriteLine("인어가 말을 한다.");
        }

        public void 수중호흡하다()
        {
            Console.WriteLine("인어가 수중호흡 한다.");
        }
    }
}

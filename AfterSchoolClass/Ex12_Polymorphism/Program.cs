using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Mammal("동물");
            mammal.Move();     // 이동한다.

            Lion lion = new Lion("사자");
            lion.Move();    // 네 발로 움직인다.

            Whale whale = new Whale("고래");
            whale.Move();   // 수영한다.

            Human human = new Human("사람");
            human.Move();   // 두 발로 움직인다.

            /* 자식이 부모 타입으로 암시적으로 형변환된 경우 */
            /* virtual, override로 선언된 메서드는 다형성이 구현되어 자식의 메서드가 실행됨. */
            mammal = lion;
            mammal.Move();     // 이동한다.

            Mammal iu = new Human("아이유");
            iu.Move();     // 이동한다.
        }
    }
}

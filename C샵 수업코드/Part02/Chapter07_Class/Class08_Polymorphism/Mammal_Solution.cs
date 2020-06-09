using System;
/* vitual, override 예약어를 사용하면  
 * 부모에서 정의한 Move()라는 하나의 메서드에 대해
 * 자식 클래스의 인스턴스에 따라 다양하게 재정의 될 수 있다. */
namespace Class07_Polymorphism_solution
{
    class Mammal
    {
        virtual public void Move()
        {
            Console.WriteLine("이동한다.");
        }
    }

    class Lion : Mammal
    {
        override public void Move()  // 부모의 메서드를 재정의하여 다형성을 구현한 메서드
        {
            Console.WriteLine("네 발로 움직인다.");
        }
    }

    class Whale : Mammal
    {
        override public void Move()
        {
            Console.WriteLine("수영한다.");
        }
    }

    class Human : Mammal
    {
        override public void Move()
        {
            Console.WriteLine("두 발로 움직인다.");
        }
    }
}

using System;

namespace Class07_Polymorphism
{
    class Mammal
    {
        public void Move()
        {
            Console.WriteLine("이동한다.");
        }
    }

    class Lion : Mammal
    {
        public void Move()
        {
            Console.WriteLine("네 발로 움직인다.");
        }
    }

    class Whale : Mammal
    {
        public void Move()
        {
            Console.WriteLine("수영한다.");
        }
    }

    class Human : Mammal
    {
        public void Move()
        {
            Console.WriteLine("두 발로 움직인다.");
        }
    }
}

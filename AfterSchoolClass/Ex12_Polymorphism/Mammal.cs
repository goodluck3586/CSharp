﻿using System;

namespace Ex12_Polymorphism
{
    #region vitual, override 예약어 사용하지 않음.
    class Mammal
    {
        public string name = "동물";

        public Mammal() { }

        public Mammal(string name)
        {
            this.name = name;
        }

        public void Move()
        {
            Console.WriteLine($"{name}이/가 이동한다.");
        }
    }

    class Lion : Mammal
    {
        public Lion(string name) : base(name) { }

        public void Move()  // 부모의 메소드와 이름과 같지만 독립적인 메소드
        {
            Console.WriteLine($"{name}이/가 네 발로 움직인다.");
        }
    }

    class Whale : Mammal
    {
        public Whale(string name) : base(name) { }

        public void Move()
        {
            Console.WriteLine($"{name}이/가 수영한다.");
        }
    }

    class Human : Mammal
    {
        public Human(string name) : base(name) { }

        public void Move()
        {
            Console.WriteLine($"{name}이/가 두 발로 움직인다.");
        }
    }
    #endregion

    #region vitual, override 예약어 사용
    /*부모에서 정의한 Move()라는 하나의 메서드에 대해 자식 클래스의 인스턴스에 따라 다양하게 재정의 될 수 있다.     */
    /*class Mammal
    {
        public String name;

        public Mammal(string name)
        {
            this.name = name;
        }

        virtual public void Move()
        {
            Console.WriteLine($"{name}이/가 이동한다.");
        }
    }

    class Lion : Mammal
    {
        public Lion(string name) : base(name) { }

        override public void Move()  // 부모의 메서드를 재정의하여 다형성을 구현한 메서드
        {
            Console.WriteLine($"{name}이/가 네 발로 움직인다.");
        }
    }

    class Whale : Mammal
    {
        public Whale(string name) : base(name) { }

        override public void Move()
        {
            Console.WriteLine($"{name}이/가 수영한다.");
        }
    }

    class Human : Mammal
    {
        public Human(string name) : base(name) { }

        override public void Move()
        {
            Console.WriteLine($"{name}이/가 두 발로 움직인다.");
        }
    }*/
    #endregion
}
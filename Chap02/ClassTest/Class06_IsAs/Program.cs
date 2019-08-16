using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class06_IsAs
{
    class Mammal
    {
        protected string name;

        public Mammal(string name)
        {
            this.name = name;
            Console.WriteLine("생성자 호출: {0}.Mammal()", name);
        }

        public string GetName()
        {
            return name;
        }
    }

    class Dog : Mammal
    {
        public Dog(string name) : base(name)
        {
            Console.WriteLine("생성자 호출: {0}.Dog()", name);
        }

        public void Bark()
        {
            Console.WriteLine($"{name}가 멍멍 짖는다.");
        }
    }

    class Cat : Mammal
    {
        public Cat(string name) : base(name)
        {
            Console.WriteLine("생성자 호출: {0}.Cat()", name);
        }

        public void Meow()
        {
            Console.WriteLine($"{name}가 야옹야옹 운다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal1 = new Dog("멍멍이");
            Mammal mammal2 = new Cat("야옹이");

            if(mammal1 is Dog)  // 같은 클래스 타입이면 true 반환
            {
                Dog dog = (Dog)mammal1;
                dog.Bark(); 
            }

            //Cat cat = (Cat)mammal1;  // 타입이 맞지 않아 에러 발생
            //Cat cat = mammal1 as Cat;  
            Cat cat = mammal2 as Cat;  // 같은 클래스 타입이면 형변환, 아니면 null값 리턴
            if (cat != null)
            {
                cat.Meow();
            }

            Dog dog2 = new Dog("댕댕이");
            Cat cat2 = new Cat("고양이");

            Wash(dog2);
            Wash(cat2);

            void Wash(Mammal mammal)
            {
                Console.WriteLine($"{mammal.GetName()}가 씻는다.");
            }
        }
    }
}

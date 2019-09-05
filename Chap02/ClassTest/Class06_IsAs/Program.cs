using System;

/* Is, As*/
namespace Class06_IsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal m1 = new Dog("멍멍이");
            Mammal m2 = new Cat("야옹이");

            if(m1 is Dog)  // 같은 클래스 타입이면 true 반환
            {
                Dog dog = (Dog)m1;
                dog.Bark(); 
            }
            
            //Cat cat = (Cat)m1;  // 타입이 맞지 않아 에러 발생, 컴파일 단계가 아닌 실행 단계에서 에러 발생
            //Cat cat = m1 as Cat;  // 타입 변환이 실패하는 경우 null값 반환
            //Console.WriteLine(cat==null?"cat=null":"null 아님");

            Cat cat = m2 as Cat;  // 같은 클래스 타입이면 형변환, 아니면 null값 리턴
            if (cat != null)
            {
                cat.Meow();
            }


            //// 동물 객체가 씻는 메소드 구현
            //void Wash(Mammal mammal)
            //{
            //    Console.WriteLine($"{mammal.GetName()}가 씻는다.");
            //}

            //Dog dog2 = new Dog("댕댕이");
            //Cat cat2 = new Cat("고양이");

            //Wash(dog2);
            //Wash(cat2);
        }

        
    }
}

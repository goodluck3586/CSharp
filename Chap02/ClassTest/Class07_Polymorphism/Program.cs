/* 메서드 오버라이드 */
namespace Class07_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal one = new Mammal();
            one.Move();

            Lion lion = new Lion();
            lion.Move();

            Whale whale = new Whale();
            whale.Move();

            Human human = new Human();
            human.Move();

            /* 자식이 부모 타입으로 암시적으로 형변환된 경우 */
            one = lion;
            one.Move();

            Mammal two = new Human();
            two.Move();
        }
    }
}

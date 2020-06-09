/* 정적 필드와 메소드 */
namespace Class02_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor p1 = new Actor("아이유");
            Actor p2 = new Actor("이선균");

            // 객체별 일반 필드 출력
            Console.WriteLine(p1.countOfInstance);
            Console.WriteLine(p2.countOfInstance);

            // 클래스 정적 필드 출력
            // 인스턴스를 만들지 않고 클래스 이름을 통해 직접 접근
            Console.WriteLine(Actor.staticCountOfInstance);

            // 인스턴스 메소드 사용
            p1.SetName("이지은");
            Console.WriteLine(p1.name);

            // 정적 메소드 사용
            Console.WriteLine($"생성된 인스턴스 숫자: {Actor.GetInstanceCount()}");
            Actor p3 = new Actor("김래원");
            Actor p4 = new Actor("김아중");
            Console.WriteLine($"생성된 인스턴스 숫자: {Actor.GetInstanceCount()}");


        }
    }
}

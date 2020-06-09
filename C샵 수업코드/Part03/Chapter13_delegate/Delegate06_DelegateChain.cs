/* 대리자 체인 */
namespace Delegate05
{
    class Program
    {
        delegate void ThereIsAFire(string location);

        static void Main(string[] args)
        {
            ThereIsAFire Fire = new ThereIsAFire(Call119);
            Fire += new ThereIsAFire(ShotOut);
            Fire += new ThereIsAFire(Escape);
            Fire("우리집");

            ThereIsAFire Fire2 = new ThereIsAFire(Call119) + new ThereIsAFire(ShotOut) + new ThereIsAFire(Escape);
            Fire2("너희집");
        }

        static void Call119(string location)
        {
            Console.WriteLine("소방서죠? 불났어요! 주소는 {0}", location);
        }

        static void ShotOut(string location)
        {
            Console.WriteLine("피하세요! {0}에 불이 났어요!", location);
        }

        static void Escape(string location)
        {
            Console.WriteLine("{0}에서 나갑시다.", location);
        }
    }
}
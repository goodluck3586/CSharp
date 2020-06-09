/* this() 생성자 */
namespace Class03_thisConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 기본 생성자 사용
            System.Console.WriteLine("*****기본 생성자 사용*****");
            Class1 a1 = new Class1();
            a1.PrintFields();

            Class1 b1 = new Class1(2);
            b1.PrintFields();

            Class1 c1 = new Class1(2, 3);
            c1.PrintFields();

            // this() 생성자 사용
            System.Console.WriteLine("*****this() 생성자 사용*****");
            Class2 a2 = new Class2();
            a2.PrintFields();

            Class2 b2 = new Class2(2);
            b2.PrintFields();

            Class2 c2 = new Class2(2, 3);
            c2.PrintFields();
        }
    }
}

/* overloading */
namespace Method03_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1,2)+"\n");
            Console.WriteLine(Plus(1.2, 3.4));
        }

        private static double Plus(double v1, double v2)
        {
            Console.WriteLine("double Plus(double v1, double v2) 호출");
            return v1 + v2;
        }

        private static int Plus(int v1, int v2)
        {
            Console.WriteLine("int Plus(int v1, int v2) 호출");
            return v1 + v2;
        }
    }
}
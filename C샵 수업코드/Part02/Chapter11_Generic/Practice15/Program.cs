/* Swap 제네릭 메소드 구현 */
namespace Exercise15_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 20;
            char c1 = 'A', c2 = 'Z';
            string s1 = "Hello", s2 = "World";

            Console.WriteLine($"n1: {n1}, n2: {n2}");
            Swap<int>(ref n1, ref n2);
            Console.WriteLine($"n1: {n1}, n2: {n2}");

            Console.WriteLine($"c1: {c1}, c2: {c2}");
            Swap<char>(ref c1, ref c2);
            Console.WriteLine($"c1: {c1}, c2: {c2}");

            Console.WriteLine($"s1: {s1}, s2: {s2}");
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"s1: {s1}, s2: {s2}");
        }

        private static void Swap<T>(ref T n1, ref T n2)
        {
            T temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
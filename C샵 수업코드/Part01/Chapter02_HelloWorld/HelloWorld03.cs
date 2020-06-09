namespace HelloWorld03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
    }
}
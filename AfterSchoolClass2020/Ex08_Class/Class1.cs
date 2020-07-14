namespace Ex08_Class
{
    internal class Class1
    {
        int a, b, c;

        public Class1()
        {
            a = 1;
            System.Console.WriteLine("Class1() 호출");
        }

        public Class1(int b) : this()
        {
            this.b = b;
            System.Console.WriteLine($"Class1({b}) 호출");
        }

        public Class1(int b, int c) : this(b)
        {
            this.c = c;
            System.Console.WriteLine($"Class1({b}, {c}) 호출");
        }

        public void printField()
        {
            System.Console.WriteLine($"a:{a}, b:{b}, c:{c}");
        }
    }
}
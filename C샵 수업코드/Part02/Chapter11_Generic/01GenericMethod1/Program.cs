class OverrideMethod
{
    public void Print(int value)
    {
        Console.WriteLine(value);
    }

    public void Print(double value)
    {
        Console.WriteLine(value);
    }

    public void Print(string value)
    {
        Console.WriteLine(value);
    }
}

class GenericMethod
{
    public void Print<T>(T value)  // T : 형식 매개 변수(Type Parameter)
    {
        Console.WriteLine(value);
    }
}


class Program
{
    static void Main(string[] args)
    {
        OverrideMethod om = new OverrideMethod();
        om.Print(1);
        om.Print(3.14);
        om.Print("Hello World");

        GenericMethod gm = new GenericMethod();
        gm.Print<int>(1);
        gm.Print<double>(3.14);
        gm.Print<string>("Hello World");
    }
}
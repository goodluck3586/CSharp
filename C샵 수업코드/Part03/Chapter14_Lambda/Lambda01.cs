/* (input-parameters) => expression */
namespace Lambda01
{
    class Program
    {
        delegate int? Calculate(int a, int b);
        delegate T Calculate2<T>(T a, T b);

        static void Main(string[] args)
        {
            // delegate 무명 메소드 표현
            Calculate calc1 = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(calc1(3, 4));

            // lambda 무명 메소드 표현(식 형식)
            Calculate calc2 = (a, b) => a + b;  // 형식 유추 기능으로 (a, b)에 type을 명시하지 않아도 된다.
            Console.WriteLine(calc2(3, 4));

            // lambda 무명 메소드 표현(문 형식)
            Calculate calc3 = (a, b) =>
            {
                if (b == 0)
                { 
                    return null;
                }
                return a / b;
            };
            Console.WriteLine(calc3(10, 2));
            Console.WriteLine(calc3(10, 0));

            Calc<double>(10, 3, (a, b) =>
            {
                if (b == 0)
                {
                    return 0;
                }
                return a / b;
            });
        }

        static void Calc<T>(T a, T b, Calculate2<T> CalcFunc)
        {
            Console.WriteLine("static void Calc<T>(T a, T b, Calculate2<T> CalcFunc)");
            Console.WriteLine(CalcFunc(a, b));
        }
    }
}
/* 델리게이트를 이용한 콜백 메서드 구현 */
namespace Delegate02_1
{
    delegate void CalcDelegateType(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            void Add(int a, int b)
            {
                Console.WriteLine($"{a} + {b} = {a + b}");
            }

            void Subtract(int a, int b)
            {
                Console.WriteLine($"{a} - {b} = {a - b}");
            }

            void Multiply(int a, int b)
            {
                Console.WriteLine($"{a} * {b} = {a * b}");
            }

            void Divide(int a, int b)
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            }

            CalcDelegateType calcFunc;
            calcFunc = Add;
            Arithmetic(3, 4, calcFunc);

            calcFunc += Subtract;
            Arithmetic(3, 4, calcFunc);

            calcFunc += Multiply;
            Arithmetic(3, 4, calcFunc);

            calcFunc += Divide;
            Arithmetic(3, 4, calcFunc);
        }

        static void Arithmetic(int a, int b, CalcDelegateType calcFunc)
        {
            calcFunc(a, b);
            Console.WriteLine();
        }
    }
}
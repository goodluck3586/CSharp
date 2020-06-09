/* 412p 예제 */
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("나누어지는 수를 입력하세요 : ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("나누는 수를 입력하세요 : ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{dividend} / {divisor} = {Divide(dividend, divisor)}");
        }
        catch(FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("프로그램을 종료합니다.");
        }
    }

    private static int Divide(int dividend, int divisor)
    {
        try
        {
            Console.WriteLine("Divide() 시작");
            return dividend / divisor;
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine("Divide()에서 예외 발생");
            throw e;
        }
        finally
        {
            Console.WriteLine("Divide() 끝");
        }
    }
}
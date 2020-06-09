/* Try Catch*/
namespace ExceptionHandling1
{
    class Program
    {
        static int[] arr = { 1, 2, 3 };

        static void ExeptionMerhod()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr[i]);

            Console.WriteLine("ExeptionMerhod() 종료");
        }

        static void TryCatchMethod()
        {
            try
            {
                for (int i = 0; i < 5; i++)
                    Console.WriteLine(arr[i]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("예외가 발생했습니다.");
                Console.WriteLine($"에러 메시지 : {e.Message}");
            }

            Console.WriteLine("TryCatchMethod() 종료");
        }

        static void Main(string[] args)
        {
            // ExeptionMerhod();
            TryCatchMethod();
        }
    }
}
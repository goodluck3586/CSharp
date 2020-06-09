/* 1급 함수(first class function)로서의 델리게이트 */
/* 델리게이트는 메서드의 반환값, 메서드의 인자, 클래스의 멤버로 사용할 수 있다.*/
namespace Delegate02
{
    // 델리게이트 선언
    delegate void PrintStrDelegate(string s);

    class PrintString
    {
        public static void Print(string str, PrintStrDelegate ps)
        {
            Console.WriteLine("Print(string str, PrintStrDelegate ps)");
            ps(str);
        }
    }

    class Program
    {
        static StreamWriter sw;

        // 콜솔 출력 메소드
        public static void WriteToScreen(string str)
        {
            Console.WriteLine($"The String is: {str}");
        }

        // 파일 출력 메소드
        public static void WriteToFile(string str)
        {
            sw = File.CreateText("MyLog.txt");
            sw.WriteLine($"The String is : {str}");
            sw.Flush();
            sw.Close();
        }

        static void Main(string[] args)
        {
            PrintStrDelegate ps1 = new PrintStrDelegate(WriteToScreen);
            PrintString.Print("Hello World", ps1);

            PrintStrDelegate ps2 = WriteToFile;
            PrintString.Print("Hello Delegate!!!", ps2);
        }
    }
}
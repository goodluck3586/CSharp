using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1급 함수(first class function)로서의 델리게이트 */
/* 델리게이트는 메서드의 반환값, 메서드의 인자, 클래스의 멤버로 사용할 수 있다.*/
namespace Delegate02
{
    // 델리게이트 선언
    public delegate void PrintStr(string s);

    class PrintString
    {
        static StreamWriter sw;

        // 콜솔 출력 메소드
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }

        // 파일 출력 메소드
        public static void WriteToFile(string str)
        {
            sw = File.CreateText("MyLog.txt");
            sw.WriteLine("The String is: {0}", str);
            sw.Flush();
            sw.Close();
        }

        // 이 메소드는 delegate를 매개변수로 받는다.
        public static void sendString(PrintStr ps)
        {
            ps("Hello World");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 델리게이트 인스턴스 생성
            PrintStr ps1 = new PrintStr(PrintString.WriteToScreen);
            PrintStr ps2 = PrintString.WriteToFile;

            // 델리게이트를 매개변수로 넘김
            PrintString.sendString(ps1);
            PrintString.sendString(ps2);

        }
    }
}

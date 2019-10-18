using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 현재시간 출력 */
namespace DateTimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //int currentTime = DateTime.Now.Hour;
            int currentTime = new DateTime(2019, 8, 13, 15, 30, 50).Hour;
            if (currentTime < 12)
            {
                Console.WriteLine($"현재 오전 {currentTime}시 입니다.");
            }
            else
            {
                Console.WriteLine($"현재 오후 {currentTime}시 입니다.");
            }
        }
    }
}

// API : https://docs.microsoft.com/ko-kr/dotnet/api/system.datetime?view=netframework-4.8

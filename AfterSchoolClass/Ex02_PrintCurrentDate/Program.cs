using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 연습문제 02 (오전/오후 여부와 시간 출력) */
namespace Ex02_PrintCurrentDate
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime 구조체 : 날짜와 시간 정보를 저장하는 구조체
            DateTime dateTime;

            dateTime = new DateTime(2020, 6, 9);                // 생성자 : public DateTime (int year, int month, int day)
            Console.WriteLine(dateTime.ToString());             // 2020-06-09 오전 12:00:00

            dateTime = new DateTime(2020, 6, 9, 16, 35, 29);    // public DateTime (int year, int month, int day, int hour, int minute, int second);
            Console.WriteLine(dateTime.ToString());             // 2020-06-09 오후 4:35:29

            // DateTime.Now 속성
            dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString());
            Console.WriteLine(dateTime.Year);
            Console.WriteLine(dateTime.Hour);

            #region "현재 오전/오후 OO시 입니다." 출력
            int currentTime = DateTime.Now.Hour;
            if (currentTime < 12)
            {
                Console.WriteLine($"현재 오전 {currentTime}시 입니다.");
            }
            else
            {
                Console.WriteLine($"현재 오후 {currentTime - 12}시 입니다.");
                Console.WriteLine($"현재 오후 {DateTime.Now.ToString("%h")}시 입니다.");
            }
            /*// Hour 속성의 값은 항상 24 시간제를 사용하여 표현된다.
            // 12 시간 형식을 사용하여 날짜 및 시간의 시간을 나타내는 문자열을 검색 하려면
            // "h" 사용자 지정 형식 지정자를 사용하여 DateTime.ToString(String) 메소드를 사용한다.*/
            #endregion
        }
    }
}

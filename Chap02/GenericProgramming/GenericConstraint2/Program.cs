using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/* 형식 매개변수에 대한 제약 조건 
* 제네릭을 사용하다 보면 형식 매개변수로 받아들이는 타입이 특정 조건을 만족해야만할 때가 있다. 
*/
namespace GenericConstraint2
{
    class Utility
    {
        #region 특정 클래스나 인터페이스를 상속한 타입만 허용
        public static int IntMax(int item1, int item2)
        {
            if (item1.CompareTo(item2) >= 0)  // 양수: item2보다 큼, 0: 같음, 음수: item2보다 작음  
                return item1;
            return item2;
        }

        public static T Max<T>(T item1, T item2) where T : IComparable  // IComparable 인터페이스를 상속받은 타입만 가능하도록 제약
        {
            if (item1.CompareTo(item2) >= 0)  // T로 대체될 타입이 모두 CompareTo 메서드를 지원한 않는다.
                return item1;
            return item2;
        }
        #endregion

        #region 값 타입, 참조 타입 제약 조건
        public static int GetSizeOf<T>(T item) where T : struct
        {
            return Marshal.SizeOf(item);  // Marshal.SizeOf(value): value값 형식의 크기를 반환한다. (float 타입은 4, decimal 타입은 16)
        }

        // 타입의 값이 null인 경우 체크해서 예외를 발생시킨다.
        public static void CheckNull<T>(T item)
        {
            if (item == null)
            {
                Console.WriteLine("null 값임.");
                //throw new ArgumentNullException();
            }   
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Utility.Max(5, 6));
            Console.WriteLine(Utility.Max(3.14, 9.87));
            Console.WriteLine(Utility.Max('Z', 'A'));
            Console.WriteLine(Utility.Max("abc", "def"));

            int num = 5;
            string str = "abc";  // string는 참조타입
            //Console.WriteLine(Utility.GetSizeOf<string>(str));  // 실행시 오류 발생
            Console.WriteLine(Utility.GetSizeOf<int>(num));
            Console.WriteLine(Utility.GetSizeOf<decimal>(3.14m));

            string str2 = null;
            int? num2 = null;
            Utility.CheckNull<string>(str2);
            Utility.CheckNull<int>(num);
            Utility.CheckNull<int?>(num2);

        }
    }
}

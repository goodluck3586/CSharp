using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Action과 Func로 더 간편하게 무명 메소드 만들기 */
/* public delegate void Action<T>(T obj) */
/* public delegate TResult Func<TResult>() */
namespace Lambda02_FuncAction
{
    class Program
    {
        delegate void AddDelegate<T1, T2>(T1 a, T2 b);
        delegate TResult SubDelegate<T1, T2, TResult>(T1 a, T2 b);

        static void Main(string[] args)
        {
            /* 사용자 정의 delegate 사용 */
            AddDelegate<int, int> addDel = (a, b) => Console.WriteLine(a+b);
            addDel(5, 10);

            SubDelegate<int, int, int> subDel = (a, b) => a-b;
            Console.WriteLine(subDel(5, 10));


            /* Action, Func 사용 */
            // 덧셈 함수 표현(반환값 없음)
            Action<int, int> add1 = (a, b) => Console.WriteLine(a + b);
            add1(3, 4);

            // 덧셈 함수 표현(반환값 있음)
            Func<int, int, int> add2 = (a, b) => a + b;
            Console.WriteLine(add2(3,4));

            // 나눗셈 표현(반환값 없음)
            Action<int, int> divide1 = (a, b) =>
            {
                if (b == 0)
                    Console.WriteLine("0으로 나눌 수 없습니다.");
                else
                    Console.WriteLine(a / b);
            };
            divide1(10, 2);

            // 나눗셈 표현(반환값 있음)
            Func<int, int, int?> divide2 = (a, b) =>
            {
                if (b == 0)
                    return null;
                return a / b;
            };
            Console.WriteLine(divide2(10, 2));
        }
    }
}

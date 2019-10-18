using System;
using System.Collections;

/* 널 조건부 연산자 */
namespace NullConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Null 조건부 연산자 
            ArrayList arr = null;
            arr?.Add("야구");  // a가 null을 반환하므로 Add() 메소드는 호출되지 않는다.
            arr?.Add("축구");
            Console.WriteLine($"Count : {arr?.Count}");
            Console.WriteLine($"arr[0] : {arr?[0]}");
            Console.WriteLine($"arr[1] : {arr?[0]}");
            Console.WriteLine();

            arr = new ArrayList();
            arr?.Add("야구");
            arr?.Add("축구");
            Console.WriteLine($"Count : {arr?.Count}");
            Console.WriteLine($"arr[0] : {arr?[0]}");
            Console.WriteLine($"arr[1] : {arr?[0]}");
            Console.WriteLine();
            #endregion

            #region Null 병합 연산자 : 변수/객체의 간결한 null 검사 
            int? a = null;
            Console.WriteLine($"{a ?? 0}");  // a가 null이면 ?? 뒤의 값이 추력된다.

            a = 99;
            Console.WriteLine($"{a ?? 0}");  // a가 null이 아니면 a의 값이 추력된다.
            Console.WriteLine();
            #endregion
        }
    }
}

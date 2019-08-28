using System;
using System.Collections;

/*
 * NullConditionalOperator
 */
namespace NullConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Null 병합 연산자 : 변수/객체의 간결한 null 검사
            int? a = null;
            Console.WriteLine($"{a ?? 0}");

            a = 99;
            Console.WriteLine($"{a ?? 0}");
            Console.WriteLine();

            // Null 조건부 연산자
            ArrayList arr = null;
            arr?.Add("야구");  // a가 null을 반환하므로 Add() 메소드는 호출되지 않는다.
            Console.WriteLine($"Count : {arr?.Count}");
            Console.WriteLine($"arr[0] : {arr?[0]}");
            Console.WriteLine();

            arr = new ArrayList();
            arr?.Add("야구");  
            Console.WriteLine($"Count : {arr?.Count}");
            Console.WriteLine($"arr[0] : {arr?[0]}");
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

/* Stack(First In Last Out)*/
namespace Collections3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region System.Collections.Stack
            Stack s = new Stack();
            s.Push(1);
            s.Push(3.14);
            s.Push('S');
            s.Push("Stack");

            while(s.Count>0)
                Console.Write($"{s.Pop()} ");
            Console.WriteLine('\n');
            #endregion

            #region System.Collections.Generic.Stack<>
            Stack<char> s2 = new Stack<char>();
            string str = "Stack";
            foreach (char c in str)
                s2.Push(c);

            Stack<int> s3 = new Stack<int>(new int[] { 1, 2, 3, 4, 5 });
            PrintStack(s3);
            #endregion
        }

        static void PrintStack(Stack<int> s)
        {
            while (s.Count > 0)
                Console.Write(s.Pop());
            Console.WriteLine('\n');
        }
    }
}

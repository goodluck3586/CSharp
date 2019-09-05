using System;

namespace Class05_Inheritance00
{
    public class A
    {
        public int value1 = 10;
        private int value2 = 20;
        protected int value3 = 30;

        // private 멤버는 기본 클래스에 중첩된 파생 클래스 에서만 접근 가능
        public class C : A
        {
            public int GetValue2()
            {
                return value2;
            }
        }
    }

    public class B : A
    {
        public int GetValue1()
        {
            return value1;
        }

        //public int GetValue2()
        //{
        //    return this.value2;  // (에러) 기본 클래스의 private 멤버에 접근 불가
        //}

        public int GetValue3()
        {
            return value3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            System.Console.WriteLine(a.value1);

            B b = new B();
            Console.WriteLine(b.GetValue1());
            Console.WriteLine(b.GetValue3());

            var c = new A.C();   // A.C
            Console.WriteLine(c.GetValue2());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Class_AccessModifier
{
    public class A
    {
        public int value1 = 10;
        protected int value2 = 20;
        private int value3 = 30;

        // private 멤버는 기본 클래스에 중첩된 파생 클래스 에서만 접근 가능
        public class C : A
        {
            public int GetValue3()
            {
                return value3;
            }
        }
    }

    public class B : A
    {
        public int GetValue1()
        {
            return value1;
        }

        public int GetValue2()
        {
            return value2;
        }

        //public int GetValue3()
        //{
        //    return this.value2;  // (에러) 기본 클래스의 private 멤버에 접근 불가
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine($"a.value1 : {a.value1}");
            //Console.WriteLine($"a.value2 : {a.value2}"); // (에러) 객체에서 protected 멤버에 접근 불가

            B b = new B();
            Console.WriteLine($"b.GetValue1() : {b.GetValue1()}");
            Console.WriteLine($"b.GetValue2() : {b.GetValue2()}");

            var c = new A.C();
            Console.WriteLine($"c.GetValue3() : {c.GetValue3()}");
        }
    }
}

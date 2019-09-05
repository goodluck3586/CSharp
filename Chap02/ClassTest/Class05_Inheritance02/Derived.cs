using System;

namespace Class05_Inheritance02
{
    class Derived : Base
    {
        public Derived(string name) : base(name) // 부모 생성자에 매개변수를 전달하며 호출
        {
            Console.WriteLine($"자식 생성자 호출 : {this.name}.Derived()");
        }

        ~Derived()
        {
            Console.WriteLine($"자식 소멸자 호출 : {this.name}.~Derived()");
        }

        public void DerivedMethod()
        {
            base.BaseMethod();  // base 키워드를 통해 부모 클래스에 접근할 수 있다.
            Console.WriteLine($"자식 메서드 호출 : {this.name}.DerivedMethod()");
        }
    }
}

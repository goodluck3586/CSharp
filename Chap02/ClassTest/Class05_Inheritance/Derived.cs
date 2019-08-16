using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05_Inheritance
{
    class Derived : Base
    {
        public Derived(string name) : base(name)
        {
            Console.WriteLine($"자식 생성자 호출 : {this.name}.Derived()");
        }

        ~Derived()
        {
            Console.WriteLine($"자식 소멸자 호출 : {this.name}.~Derived()");
        }

        public void DerivedMethod()
        {
            base.BaseMethod();
            Console.WriteLine($"자식 메서드 호출 : {name}.DerivedMethod()");
        }
    }
}

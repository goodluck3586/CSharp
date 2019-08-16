using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05_Inheritance
{
    class Base
    {
        protected string name;

        public Base(string name)
        {
            this.name = name;
            Console.WriteLine($"부모 생성자 호출 : {this.name}.Base()");
        }

        ~Base()
        {
            Console.WriteLine($"부모 소멸자 호출 : {this.name}.~Base()");
        }

        public void BaseMethod()
        {
            Console.WriteLine($"부모 메서드 호출 : {name}.BaseMethod()");
        }
    }
}

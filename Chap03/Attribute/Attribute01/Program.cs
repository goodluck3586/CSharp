using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Attribute(코드에 대한 부가 정보를 기록하고 읽을 수 있는 기능) */
namespace Attribute01
{
    class MyClass
    {
        [Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 이용하세요.")]
        public void OldMethod()
        {
            Console.WriteLine("I'm old");
        }

        public void NewMethod()
        {
            Console.WriteLine("I'm new");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.OldMethod();
            obj.NewMethod();
        }
    }
}

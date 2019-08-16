using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02_StaticField
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("아이유");
            Person person2 = new Person("이선균");

            // 객체별 일반 필드 출력
            Console.WriteLine(person1.CountOfInstance);
            Console.WriteLine(person2.CountOfInstance);

            // 클래스 정적 필드 출력
            Console.WriteLine(Person.CountOfInstanceStatic);
        }
    }
}

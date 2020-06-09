using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 얕은 복사, 깊은 복사 */
namespace Class03_DeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");
            {
                MyClass source = new MyClass();
                source.field1 = 10;
                source.field2 = 20;

                MyClass target = source;
                target.field2 = 30;

                Console.WriteLine($"{source.field1}, {source.field2}");
                Console.WriteLine($"{target.field1}, {target.field2}");
            }

            Console.WriteLine("Deep Copy");
            {
                MyClass source = new MyClass();
                source.field1 = 10;
                source.field2 = 20;

                MyClass target = source.ClassDeepCopy();
                target.field2 = 30;

                Console.WriteLine($"{source.field1}, {source.field2}");
                Console.WriteLine($"{target.field1}, {target.field2}");
            }
        }
    }
}

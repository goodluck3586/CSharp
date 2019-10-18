
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
/* reflection : C# 코드가 빌드되어 어셈블리에 포함되는 경우, 그에 대한 모든 정보를 조회할 수 있는 기술 
 * GetType()은 Type 형식의 결과를 반환한다. 
 * Type 형식은 .NET에서 사용되는 데이터 형식의 모든 정보를 담고 있다.
 * (형식 이름, 어셈블리 이름, 프로퍼티 목록, 메소드 목록, 필드 목록, 이벤트 목록, 인터페이스 목록) 등
 * Type 형식의 메소드를 이용하면 다양한 정보들을 뽑아낼 수 있다.
 */

/* 520p 예제 */
namespace Reflection01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Type type = a.GetType(); 

            PrintInterface(type);
            PrintFields(type);
            PrintProperties(type);
            PrintMehtods(type);
        }

        private static void PrintInterface(Type type)
        {
            Console.WriteLine("----------Interfaces----------");

            Type[] interfaces = type.GetInterfaces(); 
            foreach (Type i in interfaces)
                Console.WriteLine($"Name:{i.Name}");
            Console.WriteLine();
        }

        private static void PrintFields(Type type)
        {
            Console.WriteLine("----------Fields----------");

            /*FieldInfo[] fields = type.GetFields();
            foreach (FieldInfo field in fields)
                Console.WriteLine($"Name:{field.Name}");
            Console.WriteLine();*/
            FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
            foreach (FieldInfo field in fields)
            {
                String accessLevel = "protected";
                if (field.IsPublic) accessLevel = "public";
                else if (field.IsPrivate) accessLevel = "private";

                Console.WriteLine($"Access:{accessLevel}, Type:{field.FieldType.Name}, Name:{field.Name}");
            }
            Console.WriteLine();
        }

        private static void PrintMehtods(Type type)
        {
            Console.WriteLine("----------Methods----------");

            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine($"Type:{method.ReturnType.Name}, Name:{method.Name}");

                ParameterInfo[] args = method.GetParameters();
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine($"{args[i].ParameterType.Name}");
                    if(i<args.Length-1)
                        Console.Write(", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void PrintProperties(Type type)
        {
            Console.WriteLine("----------Properties----------");

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
                Console.WriteLine($"Type:{property.PropertyType.Name}, Name:{property.Name}");
            Console.WriteLine();
        }
    }
}

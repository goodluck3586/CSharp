/* 박싱/언박싱 */
/* object 형식(System.Object) */
namespace DataType02
{
    class Program
    {
        static void Main(string[] args)
        {
            /********** object 형식 **********/
            // object는 모든 형식의 부모, object 형식의 변수에 모든 형식의 값을 할당할 수 있다.
            object a = 100;
            object b = 3.141592;
            object c = true;
            object d = "Hello World";

            Console.WriteLine("{0,-12}: {1}", a, a.GetType());
            Console.WriteLine("{0,-12}: {1}", b, b.GetType());
            Console.WriteLine("{0,-12}: {1}", c, c.GetType());
            Console.WriteLine("{0,-12}: {1}", d, d.GetType());
            Console.WriteLine('\n');

            /********** Boxing 및 Unboxing **********/
            int i = 123;      // a value type
            object o = i;     // boxing(암시적)
            int j = (int)o;   // unboxing(명시적)

            //Console.WriteLine(o + j);  // Error: object는 값처럼 연산할 수 없음.
            Console.WriteLine("o + i = " + ((int)o + i));  

            // 언박싱 캐스트
            double e = 2.718281828459045;
            double f = e;
            object o1 = e;   // box
            object o2 = f; 
            //int o1 = (int)ob;  // Error: InvalidCastException
            int ee = (int)(double)e;
            Console.WriteLine(f == e);  // True
            Console.WriteLine(o1 == o2);  // Flase: 참조가 동일한지 확인하고 기본 값이 같은지 확인하지 않기 때문
            Console.WriteLine((double)o1 == (double)o2);  // True
            Console.WriteLine(o1.Equals(o2));
        }
    }
}
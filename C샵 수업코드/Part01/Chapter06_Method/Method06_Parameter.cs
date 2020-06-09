/* 메서드 파라미터 */
namespace MethodParameter
{
    class Program
    {
        public static void UseParams(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            /********** params 키워드: 가변 개수의 인수를 사용하는 메서드 매개 변수를 지정 **********/
            UseParams(1, 2, 3, 4);
            int[] myIntArray = { 5, 6, 7, 8, 9 };
            UseParams(myIntArray);


            /********** in 매개 변수 한정자: 참조로 인수 전달 **********/
            int readonlyArgument = 44;
            InArgExample(readonlyArgument);
            Console.WriteLine(readonlyArgument);     // value is still 44

            void InArgExample(in int inArg)
            {
                //number = 19;  // 읽기 전용 변수
                Console.WriteLine(inArg);
            }


            /********** ref : 참조로 인수 전달 **********/
            int number = 1;     // ref 또는 in 매개 변수로 전달하는 인수는 전달 전에 초기화해야 한다.
            Method(ref number);
            Console.WriteLine(number);  // Output: 45

            void Method(ref int refArg)
            {
                refArg = refArg + 44;
            }


            /********** out : 참조로 인수 전달 **********/
            int initializeInMethod;
            OutArgExample(out initializeInMethod);
            Console.WriteLine(initializeInMethod);     // value is now 44

            void OutArgExample(out int outArg)
            {
                outArg = 44;
            }

            string s = "123";
            
            if (int.TryParse(s, out int result))
            {
                Console.WriteLine("result : {0}", result);
            }
            Console.WriteLine("result : {0}", result);
            //int.TryParse(string s, out int result);
        }
    }
}
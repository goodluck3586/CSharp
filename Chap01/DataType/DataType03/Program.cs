using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType03
{
    class Program
    {
        enum DialogResult { YES, NO, CONFIRM, CANCEL, OK }  // 열거형(같은 범주에 속하는 여러 개의 상수 선언)

        static void Main(string[] args)
        {
            /***** 상수 *****/
            const int a = 3;
            //a = 4;  // 에러 발생

            /***** 열거형 *****/
            DialogResult result = DialogResult.OK;
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine(DialogResult.CANCEL);
            Console.WriteLine(result == DialogResult.OK);
            Console.WriteLine();

            /***** Nullable 형식 *****/
            int? n = null;

            Console.WriteLine(n.HasValue);

            n = 100;
            Console.WriteLine(n.Value);
        }
    }
}

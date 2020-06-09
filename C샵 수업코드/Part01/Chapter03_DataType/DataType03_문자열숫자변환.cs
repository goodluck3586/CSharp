/* 문자열 ↔ 숫자 변환 */
namespace DataType03
{
    class Program
    {
        static void Main(string[] args)
        {
            /********** 문자열 ↔ 숫자 변환 **********/
            string strNum = "12345";
            // int num = (int)strNum;  // Error: (int)는 숫자 형식간의 변환
            int intNum = int.Parse(strNum);

            // string str = intNum;  // Error
            string str = intNum.ToString();

            string input = Console.ReadLine();
            Console.WriteLine(input.GetType());
            int i = Convert.ToInt32(input);
        }
    }
}
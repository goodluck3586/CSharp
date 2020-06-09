/* Check Alphabet : 문자를 하나 입력받아 그것이 알파벳인지 아닌지 판별 */
namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("Enter a character : ");
            c = (char)Console.Read();

            if(c>='a' && c<='z' || c>='A' && c <= 'Z')
            {
                Console.WriteLine($"{c}는 알파벳 입니다.");
            }
            else
            {
                Console.WriteLine($"{c}는 알파벳이 아닙니다.");
            }
        }
    }
}

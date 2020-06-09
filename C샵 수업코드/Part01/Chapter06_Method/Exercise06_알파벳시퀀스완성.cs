/* <출력 형태>
FullSequenceOfLetters("ds") → "defghijklmnopqrs"
FullSequenceOfLetters("or") → "opqr" */

namespace Exercise06
{
    class Program
    {
        static string FullSequenceOfLetters(string input)
        {
            int a = input[0];
            int b = input[1];
            
            if (a <= b)
            {
                int count = b - a + 1;
                char[] lettes = new char[count];

                for (int i = 0; i < count; i++)
                {
                    lettes[i] = (char)(a + i);
                }
                string str = new string(lettes);
                return str;
            }
            else
            {
                return input;
            } 
        }
        static void Main(string[] args)
        {
            string str = FullSequenceOfLetters("sd");
            Console.WriteLine(str);
        }
    }
}
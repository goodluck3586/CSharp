namespace BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (true)
            {
                for(int j=0; j<10; j++)
                {
                    i++;
                    if (i % 3 != 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write("{0} ", i);
                    }
                }
                Console.Write("\n계속할까요?(예/아니오) : ");
                string answer = Console.ReadLine();

                if (answer == "아니오")
                    break;
            }
        }
    }
}
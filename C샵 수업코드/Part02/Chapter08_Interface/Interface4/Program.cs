/* 인터페이스를 상속하는 인터페이스 */

interface ILogger
{
    void WriteLog(string message);
}

// 특정 출력 포멧과 가변길이 매개 변수를 사용하는 WriteLog() 메소드 추가
interface IFormattableLogger : ILogger
{
    void WriteLog(string format, params Object[] args);
}

class ConsoleLogger : IFormattableLogger
{
    public void WriteLog(string message)
    {
        Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
    }

    public void WriteLog(string format, params object[] args)
    {
        string message = string.Format(format, args);
        Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IFormattableLogger logger = new ConsoleLogger();
        logger.WriteLog("The world is not flat");
        logger.WriteLog("{0} + {1} = {2}", 1, 2, 3);
    }
}
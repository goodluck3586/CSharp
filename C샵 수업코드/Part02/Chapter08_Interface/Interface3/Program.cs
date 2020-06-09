interface ILogger
{
    void WriteLog(string message);
}

class ConsoleLogger : ILogger
{
    public void WriteLog(string message)
    {
        Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
    }
}

class FileLogger : ILogger
{
    StreamWriter writer;

    public FileLogger(string path)
    {
        writer = File.CreateText(path);
        writer.AutoFlush = true;
    }

    public void WriteLog(string message)
    {
        writer.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
    }
}

class ClimateMonitor
{
    private ILogger logger;
    public ClimateMonitor(ILogger logger)
    {
        this.logger = logger;
    }

    public void start()
    {
        while (true)
        {
            Console.Write("온도를 입력해주세요.: ");
            string temperature = Console.ReadLine();
            if (temperature == "")
                break;

            logger.WriteLog("현재 온도 : " + temperature);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 콘솔에 로그 출력
        ClimateMonitor consoleMonitor = new ClimateMonitor(new ConsoleLogger());
        consoleMonitor.start();

        // 파일에 로그 출력
        ClimateMonitor fileMonitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
        fileMonitor.start();
    }
}
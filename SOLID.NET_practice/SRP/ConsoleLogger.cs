namespace SOLID.NET_practice.S;

public class ConsoleLogger : ILogger
{
    public void Log(string text, string loggingType)
    {
        Console.WriteLine("###########-START-###########");
        Console.WriteLine($"{loggingType}: {text}");
        Console.WriteLine("############-END-############");
    }
}
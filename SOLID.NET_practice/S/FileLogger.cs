namespace SOLID.NET_practice.S;

public class FileLogger : ILogger
{
    public void Log(string text, string loggingType)
    {
        var header = "###########-START-###########\n";
        var footer = "############-END-############\n";
        var logInfo =header + $"{loggingType}: {text}" + footer;
        File.AppendAllText("./logs.txt", logInfo);
    }
}
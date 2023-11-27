using System.Text;

namespace SOLID.NET_practice.S;

public class EmailMessage : ISenderMessage
{
    public string EmailFrom { get; set; }
    public string EmailTo { get; set; }
    public string EmailBody { get; set; }
    public string EmailSubject { get; set; }
    private readonly List<ILogger> _loggers = new()
    {
        new ConsoleLogger(),
        new FileLogger()
    };

    public void Send(string text)
    {
        try
        {
            this.EmailBody = text;
            Task.Delay(500); // some sending
            foreach (var logger in _loggers)
            {
                logger.Log(this.ToString(), LoggingType.Info);
            }
        }
        catch (Exception e)
        {
            foreach (var logger in _loggers)
            {
                logger.Log(this.ToString(), LoggingType.Error);
            }
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        return sb.AppendLine($"EmailFrom: {EmailFrom}")
            .AppendLine($"EmailTo: {EmailTo}")
            .AppendLine($"Subject: {EmailSubject}")
            .AppendLine($"Body: {EmailBody}")
            .ToString();
    }
}
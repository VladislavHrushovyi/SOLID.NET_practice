using System.Text;

namespace SOLID.NET_practice.S;

public class MessengerMessage : ISenderMessage
{
    public string SenderName { get; set; }
    public string ReceiverName { get; set; }
    public string MessageText { get; set; }
    private List<ILogger> _loggers = new()
    {
        new ConsoleLogger(),
        new FileLogger()
    };

    public void Send(string text)
    {
        try
        {
            this.MessageText = text;
            Task.Delay(350); // some sending to message
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

        return sb.AppendLine($"NameFrom: {SenderName}")
            .AppendLine($"NameTo: {ReceiverName}")
            .AppendLine($"Text: {MessageText}")
            .ToString();
    }
}
using System.Text;

namespace SOLID.NET_practice.S;

public sealed class Invoice : ISomeOperations
{
    public int AmountItems { get; set; }
    public DateTime InvoiceDate { get; set; }
    private readonly List<ILogger> _loggers;
    private readonly List<ISenderMessage> _sendersMessage;
    public Invoice(List<ISenderMessage> sendersMessage)
    {
        _loggers = new List<ILogger>() { new FileLogger() };
        this._sendersMessage = sendersMessage;
    }

    public void Add()
    {
        try
        {
            Task.Delay(450); //some adding logic
            foreach (var senderMessage in _sendersMessage)
            {
                senderMessage.Send(this.ToString());
            }
            
            foreach (var logger in _loggers)
            {
                logger.Log("CREATE_INVOICE" + this.ToString(), LoggingType.Info);
            }
        }
        catch (Exception e)
        {
            foreach (var logger in _loggers)
            {
                logger.Log(e.Message + "\n" +this.ToString(), LoggingType.Error);
            }
        }
    }

    public void Delete()
    {
        try
        {
            Task.Delay(450); //some adding logic
            foreach (var senderMessage in _sendersMessage)
            {
                senderMessage.Send(this.ToString());
            }
            
            foreach (var logger in _loggers)
            {
                logger.Log("DELETE_INVOICE \n" + this.ToString(), LoggingType.Info);
            }
        }
        catch (Exception e)
        {
            foreach (var logger in _loggers)
            {
                logger.Log(e.Message + "\n" + this.ToString(), LoggingType.Error);
            }
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        return sb.AppendLine($"AMOUNT: {AmountItems}")
            .AppendLine($"DATE: {InvoiceDate}")
            .ToString();
    }
}
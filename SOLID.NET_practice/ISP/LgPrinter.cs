using SOLID.NET_practice.ISP.Interfaces;
using SOLID.NET_practice.S;

namespace SOLID.NET_practice.ISP;

public class LgPrinter(string name) : IPrinterTasks, IFaxTasks
{
    private readonly ILogger _logger = new ConsoleLogger();
    public void Print(string content)
    {
        _logger.Log(name + $" printing following content:{content}", LoggingType.Info);
    }

    public void Scan(string content)
    {
        _logger.Log(name + $" scanning following content:{content}", LoggingType.Info);
    }

    public void Fax(string content)
    {
        _logger.Log(name + $" faxing following content:{content}", LoggingType.Info);
    }
}
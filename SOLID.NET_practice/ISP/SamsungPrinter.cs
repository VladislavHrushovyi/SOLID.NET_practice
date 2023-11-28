using SOLID.NET_practice.ISP.Interfaces;
using SOLID.NET_practice.S;

namespace SOLID.NET_practice.ISP;

public class SamsungPrinter(string name) : IPrinterTasks, IPrintDuplexTasks
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

    public void PrintDuplex(string content)
    {
        _logger.Log(name + $" printing following duplex content:{content}", LoggingType.Info);
    }
}
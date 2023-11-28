namespace SOLID.NET_practice.ISP.Interfaces;

public interface IPrintDuplexTasks : IPrinterTasks
{
    public void PrintDuplex(string content);
}
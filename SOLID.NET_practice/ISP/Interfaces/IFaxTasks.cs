namespace SOLID.NET_practice.ISP.Interfaces;

public interface IFaxTasks : IPrinterTasks
{
    public void Fax(string content);
}
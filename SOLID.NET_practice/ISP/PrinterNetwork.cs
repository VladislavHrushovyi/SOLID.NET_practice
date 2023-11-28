using SOLID.NET_practice.ISP.Interfaces;

namespace SOLID.NET_practice.ISP;

public class PrinterNetwork(IEnumerable<IPrinterTasks> printers)
{
    public void StartScanningMultipleContents(string content)
    {
        foreach (var printer in printers)
        {
            printer.Scan(content);
        }
    }
    public void StartPrintingMultipleContents(string content)
    {
        foreach (var printer in printers)
        {
            printer.Print(content);
        }
    }
    
    public void StartFaxingMultipleContents(string content)
    {
        foreach (var printer in printers)
        {
            if (printer is IFaxTasks faxPrinter)
            {
                faxPrinter.Fax(content);
            }
        }
    }
    
    public void StartDuplexPrintingMultipleContents(string content)
    {
        foreach (var printer in printers)
        {
            if (printer is IPrintDuplexTasks duplexPrint)
            {
                duplexPrint.PrintDuplex(content);
            }
        }
    }
}
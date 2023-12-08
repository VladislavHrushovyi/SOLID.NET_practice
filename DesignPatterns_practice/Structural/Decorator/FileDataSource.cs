namespace DesignPatterns_practice.Structural.Decorator;

public class FileDataSource(string fileName) : IDataSource
{
    public void WriteData(string data)
    {
        Console.WriteLine($"Write data to file {fileName}: [{data}]");
    }

    public string ReadData()
    {
        var data = "data test from file";
        Console.WriteLine($"Read data from file {fileName}: [{data}]");

        return data;
    }
}
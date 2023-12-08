namespace DesignPatterns_practice.Structural.Decorator;

public class CompressionDecorator(IDataSource wrappee) : DataSourceDecorator(wrappee)
{
    public override void WriteData(string data)
    {
        var compressedData = string.Join("", data.Trim().Select(x => x is < 'H' and > '2'));
        wrappee.WriteData(compressedData);
    }

    public override string ReadData()
    {
        var decompressed = string.Join('-', wrappee.ReadData().Split(""));

        return decompressed;
    }
}
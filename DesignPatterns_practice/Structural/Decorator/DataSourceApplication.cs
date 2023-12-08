namespace DesignPatterns_practice.Structural.Decorator;

public class DataSourceApplication
{
    public void DumbUsageExample()
    {
        IDataSource source = new FileDataSource("text.txt");
        source.WriteData("Allo");

        source = new CompressionDecorator(source);
        source.WriteData("alloo123456");

        source = new EncryptingDecorator(source);
        source.WriteData("allo0123456");
    }
}
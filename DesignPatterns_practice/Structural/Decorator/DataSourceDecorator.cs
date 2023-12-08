namespace DesignPatterns_practice.Structural.Decorator;

public class DataSourceDecorator(IDataSource wrappee) : IDataSource
{
    public virtual void WriteData(string data)
    {
        wrappee.WriteData(data);
    }

    public virtual string ReadData()
    {
        return wrappee.ReadData();
    }
}
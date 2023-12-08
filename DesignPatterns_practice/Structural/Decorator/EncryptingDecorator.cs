namespace DesignPatterns_practice.Structural.Decorator;

public class EncryptingDecorator(IDataSource wrappee) : DataSourceDecorator(wrappee)
{
    public override void WriteData(string data)
    {
        var encryptingData = string.Join("-", data.Reverse());
        base.WriteData(encryptingData);
    }

    public override string ReadData()
    {
        var decryptData = wrappee.ReadData().ToUpper();
        return decryptData;
    }
}
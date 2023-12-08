namespace DesignPatterns_practice.Structural.Decorator;

public class SalaryManager(IDataSource dataSource)
{
    public string Load()
    {
        return dataSource.ReadData();
    }

    public void Save()
    {
        var records = string.Join("\n", new string[] { "100", "200", "300" });
        dataSource.WriteData(records);
    }
}
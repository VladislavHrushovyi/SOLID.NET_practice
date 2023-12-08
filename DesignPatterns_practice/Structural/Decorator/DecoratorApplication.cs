namespace DesignPatterns_practice.Structural.Decorator;

public class DecoratorApplication
{
    public void RunDecoratorScenario()
    {
        var app = new DataSourceApplication();
        app.DumbUsageExample();

        IDataSource dataSource = new FileDataSource("source.txt");
        bool enabledEncryption = true; 
        if (enabledEncryption)
        {
            dataSource = new EncryptingDecorator(dataSource);
        }

        var logger = new SalaryManager(dataSource);
        Console.WriteLine(logger.Load());
        
        bool enabledComresiion = true; 
        if (enabledComresiion)
        {
            dataSource = new CompressionDecorator(dataSource);
        }

        logger = new SalaryManager(dataSource);
        Console.WriteLine(logger.Load());
    }
}
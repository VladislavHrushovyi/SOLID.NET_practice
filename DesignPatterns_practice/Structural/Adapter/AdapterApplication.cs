namespace DesignPatterns_practice.Structural.Adapter;

public class AdapterApplication
{
    public void RunAdapterScenario()
    {
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);
        
        Console.WriteLine(target.GetRequest());
    }
}
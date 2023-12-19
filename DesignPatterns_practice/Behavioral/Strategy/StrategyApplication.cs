namespace DesignPatterns_practice.Behavioral.Strategy;

public class StrategyApplication
{
    public void RunStrategyScenario()
    {
        var rnd = new Random();
        var contextStrategy = new StrategyContext(new AddStrategy());
        contextStrategy.ExecuteStrategy(rnd.Next(-100, 100),rnd.Next(-100, 100));
        
        contextStrategy.SetStrategy(new ExtractStrategy());
        contextStrategy.ExecuteStrategy(rnd.Next(-100, 100),rnd.Next(-100, 100));
        
        contextStrategy.SetStrategy(new DivideStrategy());
        contextStrategy.ExecuteStrategy(rnd.Next(-100, 100),rnd.Next(-100, 100));
        
        contextStrategy.SetStrategy(new MultiplyStrategy());
        contextStrategy.ExecuteStrategy(rnd.Next(-100, 100),rnd.Next(-100, 100));
    }
}
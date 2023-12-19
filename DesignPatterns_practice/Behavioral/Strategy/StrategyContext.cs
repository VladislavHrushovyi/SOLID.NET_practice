namespace DesignPatterns_practice.Behavioral.Strategy;

public class StrategyContext(IStrategyHandler strategy)
{
    private IStrategyHandler _strategy = strategy;

    public void SetStrategy(IStrategyHandler strategyHandler)
    {
        _strategy = strategyHandler;
    }

    public void ExecuteStrategy(double num1, double num2)
    {
        Console.WriteLine($"Data: [{num1},{num2}], Operation {_strategy.GetType().Name}");
        Console.WriteLine($"Result: {_strategy.Execute(num1, num2)}");
    }
}
namespace DesignPatterns_practice.Behavioral.Strategy;

public class ExtractStrategy : IStrategyHandler
{
    public double Execute(double num1, double num2)
    {
        return num1 - num2;
    }
}
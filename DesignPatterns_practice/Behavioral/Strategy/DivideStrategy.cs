namespace DesignPatterns_practice.Behavioral.Strategy;

public class DivideStrategy : IStrategyHandler
{
    public double Execute(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException();
        }

        return num1 / num2;
    }
}
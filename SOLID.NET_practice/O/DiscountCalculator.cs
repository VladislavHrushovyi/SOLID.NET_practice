namespace SOLID.NET_practice.O;

public class DiscountCalculator
{
    private readonly List<IDiscountStrategy> _discountStrategies;

    public DiscountCalculator(List<IDiscountStrategy> discountStrategies)
    {
        _discountStrategies = discountStrategies;
    }

    public double CalculateDiscount(double price)
    {
        foreach (var discountStrategy in _discountStrategies)
        {
            price -= discountStrategy.CalculateDiscount(price);
        }

        return price;
    }
}
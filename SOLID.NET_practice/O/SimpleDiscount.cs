namespace SOLID.NET_practice.O;

public class SimpleDiscount : IDiscountStrategy
{
    private readonly double _discount = 0.1;

    public double CalculateDiscount(double price)
    {
        return price * _discount;
    }
}
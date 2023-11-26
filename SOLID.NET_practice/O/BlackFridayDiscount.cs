namespace SOLID.NET_practice.O;

public class BlackFridayDiscount : IDiscountStrategy
{
    private readonly double _discount = 0.3;
    public double CalculateDiscount(double price)
    {
        return price * _discount;
    }
}
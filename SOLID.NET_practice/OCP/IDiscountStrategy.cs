namespace SOLID.NET_practice.O;

public interface IDiscountStrategy
{
    public double CalculateDiscount(double price)
    {
        return price;
    }
}
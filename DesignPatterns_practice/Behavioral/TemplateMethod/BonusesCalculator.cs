namespace DesignPatterns_practice.Behavioral.TemplateMethod;

public abstract class BonusesCalculator
{
    public double CalculateBonus(List<IProduct> products)
    {
        double bonuses = 0;
        foreach (var product in products)
        {
            if (product is IMilkProduct milkProduct)
            {
                bonuses += GetMilkBonus(milkProduct);
            }

            if (product is IMeatProduct meatProduct)
            {
                bonuses += GetMeatBonus(meatProduct);
            }

            bonuses += DefaultBonus(product);
        }

        return bonuses;
    }

    protected abstract double GetMilkBonus(IMilkProduct milkProduct);
    protected abstract double GetMeatBonus(IMeatProduct meatProduct);

    private double DefaultBonus(IProduct product)
    {
        return product.Price * 0.05;
    }
}
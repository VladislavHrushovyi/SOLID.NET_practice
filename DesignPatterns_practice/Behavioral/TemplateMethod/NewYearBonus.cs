namespace DesignPatterns_practice.Behavioral.TemplateMethod;

public class NewYearBonus : BonusesCalculator
{
    private readonly double _newYearBonus = 0.15;
    protected override double GetMilkBonus(IMilkProduct milkProduct)
    {
        return milkProduct.Price * _newYearBonus;
    }

    protected override double GetMeatBonus(IMeatProduct meatProduct)
    {
        return meatProduct.Price * _newYearBonus;
    }
}
namespace DesignPatterns_practice.Behavioral.TemplateMethod;

public class BlackFridayBonus : BonusesCalculator
{
    private readonly double _milkBonus = 0.1;
    private readonly double _meatBonus = 0.1;
    
    protected override double GetMilkBonus(IMilkProduct milkProduct)
    {
        return milkProduct.Price * _milkBonus;
    }

    protected override double GetMeatBonus(IMeatProduct meatProduct)
    {
        return meatProduct.Price * _meatBonus;
    }
}
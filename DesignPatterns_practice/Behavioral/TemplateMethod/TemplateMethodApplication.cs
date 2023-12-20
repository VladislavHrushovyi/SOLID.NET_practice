namespace DesignPatterns_practice.Behavioral.TemplateMethod;

public class TemplateMethodApplication
{
    public void RunTemplateMethodScenario()
    {
        var cart1 = new List<IProduct>
        {
            new CowMilk(){Price = 200},
            new CowMilk(){Price = 200},
            new GoatMilk(){Price = 250},
            new CowSausage(){Price = 350}
        };

        BonusesCalculator bonusCalculator = new BlackFridayBonus();
        Console.WriteLine($"Black friday bonus: {bonusCalculator.CalculateBonus(cart1)}");

        bonusCalculator = new NewYearBonus();
        Console.WriteLine($"New Year bonus: {bonusCalculator.CalculateBonus(cart1)}");
    }
}
namespace DesignPatterns_practice.Behavioral.TemplateMethod;

public class CowMilk : IMilkProduct
{
    public string TypeProduct { get; set; }
    public string NameProduct { get; set; }
    public double Price { get; set; }
    public string MilkType { get; set; }
}
namespace DesignPatterns_practice.Creational.Prototype;

public class Color(int red, int green, int blue) : IColorPrototype
{
    public IColorPrototype Clone()
    {
        Console.WriteLine("Cloning color RGB: {0,3},{1,3},{2,3}", red, green, blue);
        
        return this.MemberwiseClone() as IColorPrototype;
    }
}
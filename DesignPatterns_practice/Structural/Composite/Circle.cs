namespace DesignPatterns_practice.Structural.Composite;

public class Circle(int x, int y, int radius) : Dot(x, y)
{
    public new void Draw()
    {
        Console.WriteLine($"{this.GetType().Name} was drawing [X={x}, Y={y}, radius={radius}]");
    }
}
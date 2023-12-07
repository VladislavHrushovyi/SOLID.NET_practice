namespace DesignPatterns_practice.Structural.Composite;

public class Dot(int X, int Y) : IGraphic
{
    public void Move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public void Draw()
    {
        Console.WriteLine($"{this.GetType().Name} was drawing [X={X}, Y={Y}]");
    }
}
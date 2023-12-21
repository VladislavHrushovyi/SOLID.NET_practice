namespace DesignPatterns_practice.Behavioral.Visitor;

public class Dot : IShape
{
    public void Move(int x, int y)
    {
        Console.WriteLine($"Move to ({x};{y})");
    }

    public void Draw()
    {
        Console.WriteLine($"{this.GetType().Name} is drawen");
    }

    public string Accept(IVisitor visitor)
    {
        return visitor.VisitDot(this);
    }
}
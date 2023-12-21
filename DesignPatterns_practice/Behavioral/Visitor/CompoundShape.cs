namespace DesignPatterns_practice.Behavioral.Visitor;

public class CompoundShape : IShape
{
    public List<IShape> Shapes = new();
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
        return visitor.VisitCompoundShape(this);
    }
}
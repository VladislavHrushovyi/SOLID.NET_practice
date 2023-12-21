namespace DesignPatterns_practice.Behavioral.Visitor;

public interface IShape
{
    public void Move(int x, int y);
    public void Draw();
    public string Accept(IVisitor visitor);
}
namespace DesignPatterns_practice.Behavioral.Visitor;

public interface IVisitor
{
    public string VisitDot(Dot dot);
    public string VisitCircle(Circle circle);
    public string VisitRectangle(Rectangle rectangle);
    public string VisitCompoundShape(CompoundShape compoundShape);
}
using System.Runtime.CompilerServices;
using System.Text;

namespace DesignPatterns_practice.Behavioral.Visitor;

public class XmlExportVisitor : IVisitor
{
    public string VisitDot(Dot dot)
    {
        return $"<Dot>\n\t<X>{Random.Shared.Next(1,20)}</X>\n\t<Y>{Random.Shared.Next(1,20)}</Y>\n</Dot>\n";
    }

    public string VisitCircle(Circle circle)
    {
        return $"<Circle>\n\t<Radius>{Random.Shared.Next(1, 20)}</Radius>\n</Circle>\n";
    }

    public string VisitRectangle(Rectangle rectangle)
    {
        return
            $"<Rectangle>\n\t<Left>{Random.Shared.Next(1, 20)}</Left>\n\t<Top>{Random.Shared.Next(1, 20)}</Top>\n</Rectangle>\n";
    }

    public string VisitCompoundShape(CompoundShape compoundShape)
    {
        var sb = new StringBuilder();
        sb.Append("<CompoundShape>\n");
        foreach (var shape in compoundShape.Shapes)
        {
            switch (shape.GetType().Name)
            {
                case nameof(Dot):
                {
                    sb.Append("\t" + VisitDot((Dot)shape));
                    break;
                }
                case nameof(Circle):
                {
                    sb.Append("\t" + VisitCircle((Circle)shape));
                    break;
                }
                case nameof(Rectangle):
                {
                    sb.Append("\t" + VisitRectangle((Rectangle)shape));
                    break;
                }
                case nameof(CompoundShape):
                {
                    sb.Append("\t" + VisitCompoundShape((CompoundShape)shape));
                    break;
                }
            }
        }
        sb.Append("\n</CompoundShape>");
        return sb.ToString();
    }
}
namespace DesignPatterns_practice.Behavioral.Visitor;

public class VisitorApplication
{
    public void RunVisitorScenario()
    {
        var compoundShape = new CompoundShape();
        compoundShape.Shapes.Add(new Dot());
        compoundShape.Shapes.Add(new Circle());
        compoundShape.Shapes.Add(new Rectangle());
        
        var compoundShapeInner = new CompoundShape();
        compoundShapeInner.Shapes.Add(new Dot());
        compoundShapeInner.Shapes.Add(new Circle());
        
        compoundShape.Shapes.Add(compoundShapeInner);
        var shapes = new List<IShape>()
        {
            new Dot(),
            new Circle(),
            new Rectangle(),
            compoundShape
        };

        var exportVisitor = new XmlExportVisitor();
        foreach (var shape in shapes)
        {
           var xmlNode = shape.Accept(exportVisitor);
           Console.WriteLine(xmlNode);
        }
    }
}
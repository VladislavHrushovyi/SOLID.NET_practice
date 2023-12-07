namespace DesignPatterns_practice.Structural.Composite;

public class CompositeApplication
{
    public void RunCompositeScenario()
    {
        var imageEditor = new ImageEditor();
        imageEditor.Load();

        var leftBranch = new CompoundGraphic();
        leftBranch.Add(new Circle(44,33,10));
        leftBranch.Add(new Dot(223, 44));

        var rightBranch = new CompoundGraphic();
        rightBranch.Add(new CompoundGraphic());
        rightBranch.Add(new Circle(120, 44, 20));
        IGraphic[] someGraphicNodes =
        {
            leftBranch,
            rightBranch
        };
        
        imageEditor.GroupSelected(someGraphicNodes);
    }
}
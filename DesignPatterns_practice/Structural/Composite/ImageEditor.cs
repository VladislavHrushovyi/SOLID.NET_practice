namespace DesignPatterns_practice.Structural.Composite;

public class ImageEditor
{
    private CompoundGraphic AllGraphic;
    public void Load()
    {
        AllGraphic = new();
        AllGraphic.Add(new Dot(2,4));
        AllGraphic.Add(new Dot(99,3));
        AllGraphic.Add(new Circle(2,4, 15));
        AllGraphic.Add(new Circle(20,40, 22));
        
        AllGraphic.Draw();
    }

    public void GroupSelected(IGraphic[] graphics)
    {
        var group = new CompoundGraphic();
        foreach (var graphic in graphics)
        {
            group.Add(graphic);
            AllGraphic.Remove(graphic);
        }
        
        AllGraphic.Add(group);
        AllGraphic.Draw();
    }
}
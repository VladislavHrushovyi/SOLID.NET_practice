namespace DesignPatterns_practice.Structural.Composite;

public class CompoundGraphic : IGraphic
{
    private List<IGraphic> _graphics = new();

    public void Add(IGraphic child)
    {
        _graphics.Add(child);
    }

    public void Remove(IGraphic child)
    {
        _graphics.Remove(child);
    }
    public void Move(int x, int y)
    {
        foreach (var graphic in _graphics)
        {
            graphic.Move(x, y);
        }
    }

    public void Draw()
    {
        foreach (var graphic in _graphics)
        {
            graphic.Draw();
        }
    }
}
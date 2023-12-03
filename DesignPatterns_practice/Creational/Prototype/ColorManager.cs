namespace DesignPatterns_practice.Creational.Prototype;

public class ColorManager
{
    private Dictionary<string, IColorPrototype> _colors = new();

    public IColorPrototype this[string key]
    {
        get => _colors[key];
        set => _colors.Add(key, value);
    }
}
namespace DesignPatterns_practice.Structural.Adapter;

public class Adapter(Adaptee adaptee) : ITarget
{
    public string GetRequest()
    {
        return $"This is {adaptee.GetSpecificRequest()}";
    }
}
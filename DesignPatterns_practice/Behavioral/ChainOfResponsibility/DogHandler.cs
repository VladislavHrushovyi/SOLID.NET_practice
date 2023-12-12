namespace DesignPatterns_practice.Behavioral.ChainOfResponsibility;

public class DogHandler : AbstractHandler
{
    public override object Handle(object request)
    {
        if (request is string s and "Meatball")
        {
            return $"Dog: I`ll eat the {s}\n";
        }
        return base.Handle(request);
    }
}
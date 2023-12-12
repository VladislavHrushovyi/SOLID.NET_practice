namespace DesignPatterns_practice.Behavioral.ChainOfResponsibility;

public class MonkeyHandler : AbstractHandler
{
    public override object Handle(object request)
    {
        if ((request is string s and "Banana"))
        {
            return $"Monkey: I`ll eat the {s}\n";
        }

        return base.Handle(request);
    }
}
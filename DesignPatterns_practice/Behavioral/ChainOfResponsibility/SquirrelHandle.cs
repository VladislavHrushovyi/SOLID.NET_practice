namespace DesignPatterns_practice.Behavioral.ChainOfResponsibility;

public class SquirrelHandle : AbstractHandler
{
    public override object Handle(object request)
    {
        if (request is string s and  "Nut")
        {
            return $"Squirrel: I`ll eat the {request}\n";
        }
        return base.Handle(request);
    }
}
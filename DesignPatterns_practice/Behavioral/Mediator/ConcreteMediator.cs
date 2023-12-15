namespace DesignPatterns_practice.Behavioral.Mediator;

public class ConcreteMediator : IMediator
{
    private readonly Component1 _c1;
    private readonly Component2 _c2;
    
    public ConcreteMediator(Component1 c1, Component2 c2)
    {
        _c1 = c1;
        _c1.SetMediator(this);
        _c2 = c2;
        _c2.SetMediator(this);
    }
    public void Notify(object sender, string ev)
    {
        switch (ev)
        {
            case "A":
            {
                Console.WriteLine($"Mediator reacts on {ev} and triggers following operation");
                _c1.DoB();
                break;
            }
            case "B":
            {
                Console.WriteLine($"Mediator reacts on {ev} and triggers following operation");
                _c2.DoC();
                break;
            }
            default:
            {
                Console.WriteLine("Does not find handling mediator");
                break;
            }
        }
    }
}
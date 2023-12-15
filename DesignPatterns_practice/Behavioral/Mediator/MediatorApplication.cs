namespace DesignPatterns_practice.Behavioral.Mediator;

public class MediatorApplication
{
    public void RunMediatorScenario()
    {
        var c1 = new Component1();
        var c2 = new Component2();

        new ConcreteMediator(c1, c2);
        
        Console.WriteLine("Client triggers operation A.");
        c1.DoA();
        
        Console.WriteLine("Client triggers operation D.");
        c2.DoD();
    }
}
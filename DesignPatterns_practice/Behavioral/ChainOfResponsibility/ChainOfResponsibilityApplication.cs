namespace DesignPatterns_practice.Behavioral.ChainOfResponsibility;

public class ChainOfResponsibilityApplication
{
    public void RunChainOfResponsibilityScenario()
    {
        var dog = new DogHandler();
        var monkey = new MonkeyHandler();
        var squirrel = new SquirrelHandle();
        dog.SetNext(monkey).SetNext(squirrel);
        Client.SomeUseCaseOfChain(dog);
        Client.SomeUseCaseOfChain(monkey);
    }
}
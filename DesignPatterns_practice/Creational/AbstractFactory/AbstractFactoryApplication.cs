using DesignPatterns_practice.Creational.AbstractFactory.Factories;

namespace DesignPatterns_practice.Creational.AbstractFactory;

public class AbstractFactoryApplication
{
    public void RunExampleFactory()
    {
        ContinentFactory africa = new AfricaFactory();
        AnimalWorld world = new AnimalWorld(africa);
        world.RunFoodChain();

        ContinentFactory america = new AmericaFactory();
        world = new AnimalWorld(america);
        world.RunFoodChain();
    }
}
using DesignPatterns_practice.Creational.AbstractFactory.Factories;
using DesignPatterns_practice.Creational.AbstractFactory.Products;

namespace DesignPatterns_practice.Creational.AbstractFactory;

public class AnimalWorld(ContinentFactory continentFactory)
{
    private readonly Herbivore _herbivore = continentFactory.CreateHerbivore();
    private readonly Carnivore _carnivore = continentFactory.CreateCarnivore();

    public void RunFoodChain()
    {
        _carnivore.Eat(_herbivore);
    }
}
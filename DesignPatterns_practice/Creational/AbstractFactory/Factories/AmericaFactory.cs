using DesignPatterns_practice.Creational.AbstractFactory.Products;
using DesignPatterns_practice.Creational.AbstractFactory.Products.AmericanAnimal;

namespace DesignPatterns_practice.Creational.AbstractFactory.Factories;

public class AmericaFactory : ContinentFactory
{
    public override Herbivore CreateHerbivore()
    {
        return new Bison();
    }

    public override Carnivore CreateCarnivore()
    {
        return new Wolf();
    }
}
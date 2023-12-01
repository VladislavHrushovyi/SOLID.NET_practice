using DesignPatterns_practice.Creational.AbstractFactory.Products;

namespace DesignPatterns_practice.Creational.AbstractFactory.Factories;

public abstract class ContinentFactory
{
    public abstract Herbivore CreateHerbivore();
    public abstract Carnivore CreateCarnivore();
}
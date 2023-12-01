namespace DesignPatterns_practice.Creational.AbstractFactory.Products.AmericanAnimal;

public class Wolf : Carnivore
{
    public override void Eat(Herbivore animal)
    {
        Console.WriteLine(this.GetType().Name + " eats " + animal.GetType().Name);
    }
}
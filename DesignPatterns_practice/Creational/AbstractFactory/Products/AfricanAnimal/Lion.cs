namespace DesignPatterns_practice.Creational.AbstractFactory.Products;

public class Lion : Carnivore
{
    public override void Eat(Herbivore animal)
    {
        Console.WriteLine(this.GetType().Name + " eats" + animal.GetType().Name);
    }
}
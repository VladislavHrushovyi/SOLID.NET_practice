namespace DesignPatterns_practice.Behavioral.ChainOfResponsibility;

public class Client
{
    public static void SomeUseCaseOfChain(AbstractHandler handler)
    {
        var foods = new string[] { "Banana", "Nut", "Coffee" };
        foreach (var food in foods)
        {
            Console.WriteLine($"Client: Who wants a food {food}");
            var result = handler.Handle(food);

            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"{food} was left untouched");
            }
        }
    }
}
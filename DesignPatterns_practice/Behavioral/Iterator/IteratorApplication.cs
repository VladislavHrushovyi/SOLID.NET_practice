namespace DesignPatterns_practice.Behavioral.Iterator;

public class IteratorApplication
{
    public void RunIteratorScenario()
    {
        var collection = new WordCollection();
        collection.AddItem("A");
        collection.AddItem("B");
        collection.AddItem("C");
        collection.AddItem("D");

        Console.WriteLine("Straight traversal");
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("Reverse traversal");
        collection.ReverseDirection();
        
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }
}
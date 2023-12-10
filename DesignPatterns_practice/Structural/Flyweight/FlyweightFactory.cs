using System.Runtime.CompilerServices;

namespace DesignPatterns_practice.Structural.Flyweight;

public class FlyweightFactory(params Car[] args)
{
    private List<Tuple<Flyweight, string>> _flyweights =
        args.Select(x => new Tuple<Flyweight, string>(new Flyweight(x), GetKey(x))).ToList();

    private static string GetKey(Car car)
    {
        List<string> elements = new List<string>();
        
        elements.Add(car.Model);
        elements.Add(car.Color);
        elements.Add(car.Company);

        if (car is { Owner: not null, Number: not null })
        {
            elements.Add(car.Owner);
            elements.Add(car.Number);
        }
        
        elements.Sort();

        return string.Join("_", elements);
    }

    public Flyweight GetFlyweight(Car sharedState)
    {
        var key = GetKey(sharedState);
        if (_flyweights.All(x => x.Item2 != key))
        {
            Console.WriteLine("FlyweightFactory: Can`t find flyweight, creating new one.");
            _flyweights.Add(new(new Flyweight(sharedState), key));
        }
        else
        {
            Console.WriteLine("FlyweightFactory: Reusing existing flyweight");
        }

        return _flyweights.Single(x => x.Item2 == key).Item1;
    }

    public void PrintFlyweights()
    {
        var count = _flyweights.Count;
        Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
        foreach (var flyweight in _flyweights)
        {
            Console.WriteLine(flyweight.Item2);
        }
    }
}
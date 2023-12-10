
using System.Text.Json.Serialization;

namespace DesignPatterns_practice.Structural.Flyweight;

public class Flyweight(Car car)
{
    public void Operation(Car uniqueState)
    {
        string s = car.ToJson();
        string u = uniqueState.ToJson();
        
        Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
    }
}
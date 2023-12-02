namespace DesignPatterns_practice.Creational.Builder;

public class Vehicle(string vehicleType)
{
    private readonly string _vehicleType = vehicleType;
    private readonly Dictionary<string, string> _parts = new();

    public string this[string key]
    {
        get => _parts[key];
        set => _parts[key] = value;
    }

    public void Show()
    {
        Console.WriteLine("\n-----------VEHICLE------------");
        Console.WriteLine($"{nameof(_vehicleType)}: {_vehicleType}");
        foreach (var part in _parts)
        {
            Console.WriteLine($"{part.Key}: {part.Value}");
        }
        Console.WriteLine("-----------------------------\n");
    }
}
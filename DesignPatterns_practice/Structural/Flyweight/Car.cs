using System.Text;

namespace DesignPatterns_practice.Structural.Flyweight;

public class Car
{
    public string Owner { get; set; }
    public string Number { get; set; }
    public string Company { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    public string ToJson()
    {
        var sb = new StringBuilder();
        return sb.Append("{ ")
            .Append($"\"Owner\": \"{Owner}\" ")
            .Append($"\"Number\": \"{Number}\" ")
            .Append($"\"Company\": \"{Company}\" ")
            .Append($"\"Model\": \"{Model}\" ")
            .Append($"\"Color\": \"{Color}\"")
            .Append(" }")
            .ToString();
    }
}
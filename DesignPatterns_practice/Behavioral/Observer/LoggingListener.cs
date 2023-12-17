namespace DesignPatterns_practice.Behavioral.Observer;

public class LoggingListener(string fileName, string message) : IEventListener
{
    public void Update(string fileName)
    {
       Console.WriteLine($"LOG to file {fileName} message: {message}");
    }
}
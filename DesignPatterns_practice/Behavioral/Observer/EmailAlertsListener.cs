namespace DesignPatterns_practice.Behavioral.Observer;

public class EmailAlertsListener(string email, string message) : IEventListener
{
    public void Update(string fileName)
    {
        Console.WriteLine($"Send to {email} message: {message}");
    }
}
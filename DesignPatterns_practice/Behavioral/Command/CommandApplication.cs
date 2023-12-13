namespace DesignPatterns_practice.Behavioral.Command;

public class CommandApplication
{
    public void RunCommandScenario()
    {
        var app = new Application();
        app.CreateUI();
    }
}
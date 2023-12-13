namespace DesignPatterns_practice.Behavioral.Command.Commands;

public class Button
{
    private Action _command;
    public void SetCommand(Action command)
    {
        _command = command;
    }
    public void Click()
    {
        if (_command is not null)
        {
            _command.Invoke();
            Console.WriteLine("on click event");
        }
    }
}
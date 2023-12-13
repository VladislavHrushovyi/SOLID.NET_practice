namespace DesignPatterns_practice.Behavioral.Command.Commands;

public class CommandHistory
{
    private List<AbstractCommand> _commands = new();

    public void PushCommand(AbstractCommand command)
    {
        _commands.Add(command);
    }

    public AbstractCommand PopCommand()
    {
        var recentCommand = _commands[^1];
        _commands = _commands[..^2];
        return recentCommand;
    }
}
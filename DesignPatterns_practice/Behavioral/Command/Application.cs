using DesignPatterns_practice.Behavioral.Command.Commands;

namespace DesignPatterns_practice.Behavioral.Command;

public class Application
{
    public string Clipboard { get; set; } = string.Empty;
    public List<Editor> Editors { get; set; } = new();
    public Editor ActiveEditor { get; set; } = new(){Text = "1999-06-09"};
    public CommandHistory CommandHistory { get; set; } = new();

    public void CreateUI()
    {
        Button button = new Button();
        var copy = () =>
        {
            ExecuteCommand(new CopyCommand(this, ActiveEditor, "12345"));
            Console.WriteLine($"Copy Command: [Clipboard = \"{Clipboard}\"]");
        };
        button.SetCommand(copy);
        button.Click();
        
        var cut = () =>
        {
            ExecuteCommand(new CutCommand(this, ActiveEditor, "345"));
            Console.WriteLine($"Cut Command: [Clipboard = \"{Clipboard}\"]");
        };
        button.SetCommand(cut);
        button.Click();
        
        var paste = () =>
        {
            ExecuteCommand(new PasteCommand(this, ActiveEditor, "444"));
            Console.WriteLine($"Paste Command: [Clipboard = \"{Clipboard}\"]");
        };
        button.SetCommand(paste);
        button.Click();
        
        var undo = () =>
        {
            ExecuteCommand(new UndoCommand(this, ActiveEditor, "098765"));
            Console.WriteLine($"Undo Command: [Clipboard = \"{Clipboard}\"]");
        };
        button.SetCommand(undo);
        button.Click();
        
    }

    private void ExecuteCommand(AbstractCommand command)
    {
        if (command.Execute())
        {
            CommandHistory.PushCommand(command);
        }
    }

    public void Undo()
    {
        var command = CommandHistory.PopCommand();
        if (command is not null)
        {
            command.Undo();
        }
    }
}
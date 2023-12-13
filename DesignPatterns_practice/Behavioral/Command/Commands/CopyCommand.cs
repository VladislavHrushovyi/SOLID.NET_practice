namespace DesignPatterns_practice.Behavioral.Command.Commands;

public class CopyCommand(Application app, Editor editor, string backup) : AbstractCommand(app, editor, backup)
{
    public override bool Execute()
    {
        app.Clipboard = editor.GetSelection();
        return false;
    }
}
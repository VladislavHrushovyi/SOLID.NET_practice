namespace DesignPatterns_practice.Behavioral.Command.Commands;

public class UndoCommand(Application app, Editor editor, string backup) : AbstractCommand(app, editor, backup)
{
    public override bool Execute()
    {
        app.Undo();
        return false;
    }
}
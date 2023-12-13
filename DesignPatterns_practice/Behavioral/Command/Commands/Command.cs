namespace DesignPatterns_practice.Behavioral.Command.Commands;

public abstract class AbstractCommand(Application app, Editor editor, string backup)
{
    public void SaveBackup()
    {
        backup = editor.Text;
    }

    public void Undo()
    {
        editor.Text = backup;
    }

    public abstract bool Execute();
}
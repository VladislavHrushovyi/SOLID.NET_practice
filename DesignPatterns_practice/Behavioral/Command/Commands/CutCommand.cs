namespace DesignPatterns_practice.Behavioral.Command.Commands;

public class CutCommand(Application app, Editor editor, string backup) : AbstractCommand(app, editor, backup)
{
    public override bool Execute()
    {
        SaveBackup();
        app.Clipboard = editor.GetSelection();
        editor.DeleteSelection();

        return true;
    }
}
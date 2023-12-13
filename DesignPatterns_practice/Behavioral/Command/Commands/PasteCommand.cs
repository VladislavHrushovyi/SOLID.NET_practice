namespace DesignPatterns_practice.Behavioral.Command.Commands;

public class PasteCommand(Application app, Editor editor, string backup) : AbstractCommand(app, editor, backup)
{
    public override bool Execute()
    {
        SaveBackup();
        editor.ReplaceSelection(app.Clipboard);

        return true;
    }
}
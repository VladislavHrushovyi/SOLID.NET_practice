namespace DesignPatterns_practice.Behavioral.Memento;

public class Command(Editor editor)
{
    private readonly Stack<Snapshot> _backups = new ();

    public void MakeBackup()
    {
        _backups.Push(editor.CreateSnapshot());
    }

    public void Undo()
    {
        if (_backups.Count == 0) return;
        var recentBackup = _backups.Pop();
        recentBackup.Restore();
    }
}
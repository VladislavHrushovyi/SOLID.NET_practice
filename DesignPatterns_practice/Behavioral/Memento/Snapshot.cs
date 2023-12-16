namespace DesignPatterns_practice.Behavioral.Memento;

public class Snapshot(Editor editor,string text, int curX, int curY, int selectionWidth)
{
    public void Restore()
    {
        editor.SetText(text);
        editor.SetCursorPosition(curX, curY);
        editor.SetSelectionWidth(selectionWidth);
    }
}
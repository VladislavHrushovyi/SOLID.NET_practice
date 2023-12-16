namespace DesignPatterns_practice.Behavioral.Memento;

public class Editor
{
    private string _text = String.Empty;
    private int _curX = Int32.MaxValue;
    private int _curY = Int32.MaxValue;
    private int _selectionWidth = Int32.MaxValue;

    public void SetText(string text)
    {
        _text = text;
    }

    public void SetCursorPosition(int curX, int curY)
    {
        _curX = curX;
        _curY = curY;
    }

    public void SetSelectionWidth(int width)
    {
        _selectionWidth = width;
    }

    public Snapshot CreateSnapshot()
    {
        return new Snapshot(this, _text, _curX, _curY, _selectionWidth);
    }

    public override string ToString()
    {
        return $"Text = {_text}, cursor = ({_curX},{_curY}) selectionWidth = {_selectionWidth}";
    }
}
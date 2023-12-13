namespace DesignPatterns_practice.Behavioral.Command;

public class Editor
{
    public string Text { get; set; }

    public string GetSelection()
    {
        return Text;
    }

    public void DeleteSelection()
    {
        Text = String.Empty;
    }

    public void ReplaceSelection(string text)
    {
        Text = text;
    }
}
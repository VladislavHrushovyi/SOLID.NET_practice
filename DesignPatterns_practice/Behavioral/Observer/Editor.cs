namespace DesignPatterns_practice.Behavioral.Observer;

public class Editor
{
    public EventManager EventManager = new();
    private string _fileName = String.Empty;

    public void OpenFile(string path)
    {
        _fileName = path;
        Console.WriteLine($"Open the {_fileName} file");
        EventManager.Notify("open",_fileName );
    }

    public void SaveFile()
    {
        Console.WriteLine($"Save the {_fileName} file");
        EventManager.Notify("save", _fileName);
    }
}
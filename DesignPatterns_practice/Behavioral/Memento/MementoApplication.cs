using System.Text;

namespace DesignPatterns_practice.Behavioral.Memento;

public class MementoApplication
{
    public void RunMementoScenario()
    {
        var editor = new Editor();
        var commands = new Command(editor);

        for (int i = 0; i < 5; i++)
        {
            editor.SetText(GetRandomString());
            editor.SetCursorPosition(Random.Shared.Next(1,100), Random.Shared.Next(1,100));
            editor.SetSelectionWidth(Random.Shared.Next(1,15));
            commands.MakeBackup();
            Console.WriteLine(editor);
        }

        for (int i = 0; i < 5; i++)
        {
            commands.Undo();
            Console.WriteLine(editor);
        }
    }

    private string GetRandomString()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < Random.Shared.Next(0,15); i++)
        {
            sb.Append((char)('A' + Random.Shared.Next(0, 26)));
        }

        return sb.ToString();
    }
}
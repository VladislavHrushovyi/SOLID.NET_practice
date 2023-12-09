namespace DesignPatterns_practice.Structural.Facade;

public class VideoFile(string fileName)
{
    public string FileName { get; } = fileName.Split(".")[0];
    public string Codec { get; } = fileName.Split(".")[1];

    public void Execute()
    {
        Console.WriteLine($"Working with {fileName}");
    }
}
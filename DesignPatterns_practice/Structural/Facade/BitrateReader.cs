namespace DesignPatterns_practice.Structural.Facade;

public static class BitrateReader
{
    public static string Read(string filename, string sourceCodec)
    {
        Console.WriteLine($"{filename} reads {sourceCodec}");
        return filename;
    }

    public static string Convert(string buffer, string destinationCodec)
    {
        Console.WriteLine($"{buffer}.{destinationCodec}");
        return $"{buffer}.{destinationCodec}";
    }
}
namespace DesignPatterns_practice.Structural.Proxy;

public class VideoHandler : IVideoHandler
{
    private readonly List<Tuple<int, string>> _videos = new()
    {
        new Tuple<int, string>(1, "Test video 1"),
        new Tuple<int, string>(2, "Test video 2"),
        new Tuple<int, string>(3, "Test video 3"),
        new Tuple<int, string>(4, "Test video 4"),
        new Tuple<int, string>(5, "Test video 5"),
    };
    public IEnumerable<string> ListVideos()
    {
        Task.Delay(2000); //some calling api
        return _videos.Select(x => x.Item2);
    }

    public string GetVideoInfo(int id)
    {
        Task.Delay(2000); //some calling api
        return _videos.Single(x => x.Item1 == id).Item2;
    }

    public void DownloadVideo(int id)
    {
        Task.Delay(2000); //some calling api
        var searchedVideo = _videos.Single(x => x.Item1 == id).Item2;
        Console.WriteLine($"Downloading video: {searchedVideo}");
    }
}
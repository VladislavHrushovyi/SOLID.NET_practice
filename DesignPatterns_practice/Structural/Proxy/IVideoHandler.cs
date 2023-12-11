namespace DesignPatterns_practice.Structural.Proxy;

public interface IVideoHandler
{
    public IEnumerable<string> ListVideos();
    public string GetVideoInfo(int id);
    public void DownloadVideo(int id);
}
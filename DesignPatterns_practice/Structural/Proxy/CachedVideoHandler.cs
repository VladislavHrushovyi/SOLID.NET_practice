namespace DesignPatterns_practice.Structural.Proxy;

public class CachedVideoHandler(IVideoHandler videoService) : IVideoHandler
{
    private IEnumerable<string> _listVideoCash;
    private string _videoCash;

    public bool IsNeedReset = false;
    public IEnumerable<string> ListVideos()
    {
        if (_listVideoCash is null || IsNeedReset)
        {
            Console.WriteLine("Data list of video from cash");
            _listVideoCash = videoService.ListVideos();
        }

        return _listVideoCash;
    }

    public string GetVideoInfo(int id)
    {
        if (_videoCash == null || IsNeedReset)
        {
            Console.WriteLine("Data of video from cash");
            _videoCash = videoService.GetVideoInfo(id);
        }

        return _videoCash;
    }

    public void DownloadVideo(int id)
    {
        if (IsDownloadExist(id))
        {
            Console.WriteLine($"Download from cash {_videoCash}");
        }
        
        videoService.DownloadVideo(id);
    }

    private bool IsDownloadExist(int id)
    {
        var videoInfo = videoService.GetVideoInfo(id);
        if (videoInfo == _videoCash)
        {
            return true;
        }
        return false;
    }
}
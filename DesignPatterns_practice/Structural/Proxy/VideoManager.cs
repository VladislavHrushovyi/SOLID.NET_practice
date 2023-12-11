namespace DesignPatterns_practice.Structural.Proxy;

public class VideoManager(IVideoHandler videoHandler)
{
    private void RenderVideoPage(int idVideo)
    {
        var info = videoHandler.GetVideoInfo(idVideo);
        Console.WriteLine($"Render page with video {info}");
    }

    private void RenderListPanel()
    {
        var list = videoHandler.ListVideos();
        var listOfVideoString = string.Join("\n", list);
        Console.WriteLine($"Video list panel: \n{listOfVideoString}");
    }

    public void ReactOnUserAction()
    {
        RenderVideoPage(1);
        RenderListPanel();
        
        RenderVideoPage(1);
        RenderListPanel();
        
        RenderVideoPage(4);
        RenderListPanel();
        
        RenderVideoPage(4);
        RenderListPanel();
    }
}
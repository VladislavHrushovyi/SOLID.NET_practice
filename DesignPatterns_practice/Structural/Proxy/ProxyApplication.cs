namespace DesignPatterns_practice.Structural.Proxy;

public class ProxyApplication
{
    public void RunProxyScenario()
    {
        var videoService = new VideoHandler();
        var proxyVideoHandler = new CachedVideoHandler(videoService);

        var manager = new VideoManager(proxyVideoHandler);
        manager.ReactOnUserAction();
    }
}
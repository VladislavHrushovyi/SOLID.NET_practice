namespace DesignPatterns_practice.Creational.Singleton;

public sealed class LoadBalancerSingleton
{
    private readonly static LoadBalancerSingleton _instance = new LoadBalancerSingleton();
    private readonly List<Server> _servers;

    private LoadBalancerSingleton()
    {
        _servers = new List<Server>()
        {
            new (){Name = "Server-1", IP = "127.0.0.1"},
            new (){Name = "Server-2", IP = "127.0.0.2"},
            new (){Name = "Server-3", IP = "127.0.0.3"},
            new (){Name = "Server-4", IP = "127.0.0.4"},
            new (){Name = "Server-5", IP = "127.0.0.5"},
        };
    }

    public static LoadBalancerSingleton GetLoadBalancer()
    {
        return _instance;
    }

    public Server Server => _servers[Random.Shared.Next(_servers.Count)];
}

public class Server
{
    public required string Name { get; set; }
    public required string IP { get; set; }
}
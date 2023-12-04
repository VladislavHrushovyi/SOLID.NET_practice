namespace DesignPatterns_practice.Creational.Singleton;

public class SingletonApplication
{
    public void RunSingletonScenario()
    {
        var b1 = LoadBalancerSingleton.GetLoadBalancer();
        var b2 = LoadBalancerSingleton.GetLoadBalancer();
        var b3 = LoadBalancerSingleton.GetLoadBalancer();
        var b4 = LoadBalancerSingleton.GetLoadBalancer();
        var b5 = LoadBalancerSingleton.GetLoadBalancer();

        if (b1 == b2 && b2 == b3 && b3 == b4 && b4 == b5 && b5 == b1)
        {
            Console.WriteLine("The same instances of server balancer");
        }

        var balancer = LoadBalancerSingleton.GetLoadBalancer();
        for (int i = 0; i < 20; i++)
        {
            string serverName = balancer.Server.Name;
            Console.WriteLine($"Dispatch to next server: {serverName}");
        }
    }
}
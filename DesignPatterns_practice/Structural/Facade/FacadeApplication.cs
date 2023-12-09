namespace DesignPatterns_practice.Structural.Facade;

public class FacadeApplication
{
    public void RunFacadeScenario()
    {
        var convertor = new VideoConverter();
        convertor.Convert();
    }
}
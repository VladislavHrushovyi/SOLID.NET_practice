namespace DesignPatterns_practice.Behavioral.ChainOfResponsibility;

public interface IHandler
{
    IHandler SetNext(IHandler handler);
    object Handle(object request);
}
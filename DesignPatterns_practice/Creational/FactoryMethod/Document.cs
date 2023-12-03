using DesignPatterns_practice.Creational.FactoryMethod.Pages;

namespace DesignPatterns_practice.Creational.FactoryMethod;

public abstract class Document
{
    protected Document()
    {
        this.CreatePages();
    }

    public List<Page> Pages { get; } = new();

    protected abstract void CreatePages();
}
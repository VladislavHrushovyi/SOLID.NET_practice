using DesignPatterns_practice.Creational.FactoryMethod.Pages;

namespace DesignPatterns_practice.Creational.FactoryMethod;

public class Report : Document
{
    protected override void CreatePages()
    {
        Pages.Add(new IntroductionPage("Hello, my name Grigirovich"));
        Pages.Add(new ResultsPage("Accepted"));
        Pages.Add(new ConclusionPage("Good work"));
        Pages.Add(new SummaryPage("Bla bla work, have some mistakes, bla bla..."));
        Pages.Add(new BibliographyPage("Lorem ipsun bla bla ..."));
    }
}
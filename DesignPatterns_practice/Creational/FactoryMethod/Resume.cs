using DesignPatterns_practice.Creational.FactoryMethod.Pages;

namespace DesignPatterns_practice.Creational.FactoryMethod;

public class Resume : Document
{
    protected override void CreatePages()
    {
        Pages.Add(new SkillPage("C#, C++, OOP, TDD, MVC, SQL"));
        Pages.Add(new EducationPage("University, Bachelor, Masters"));
        Pages.Add(new ExperiencePage("No experience"));
    }
}
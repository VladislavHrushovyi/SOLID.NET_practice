namespace DesignPatterns_practice.Creational.FactoryMethod;

public class FactoryMethodApplication
{
    public void RunFactoryMethodScenario()
    {
        Document[] documents = new Document[2];

        documents[0] = new Resume();
        documents[1] = new Report();

        foreach (var document in documents)
        {
            Console.WriteLine("\n" + document.GetType().Name );
            foreach (var page in document.Pages)
            {
                Console.WriteLine(page.GetType().Name + $": {page.Value}");
            }
        }
    }
}
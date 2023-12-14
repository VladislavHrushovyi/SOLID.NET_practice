using System.Collections;

namespace DesignPatterns_practice.Behavioral.Iterator;

public class WordCollection : IteratorAggregate
{
    private List<string> _words = new();
    private bool _direction = false;

    public void ReverseDirection()
    {
        _direction = !_direction;
    }

    public List<string> GetItems()
    {
        return _words;
    }

    public void AddItem(string item)
    {
        _words.Add(item);
    }
    public override IEnumerator GetEnumerator()
    {
        return new AlphabeticalOrderIterator(this, _direction);
    }
}
using System.Collections;

namespace DesignPatterns_practice.Behavioral.Iterator;

public abstract class IteratorAggregate : IEnumerable
{
    public abstract IEnumerator GetEnumerator();
}
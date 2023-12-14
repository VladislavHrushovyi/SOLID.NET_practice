
namespace DesignPatterns_practice.Behavioral.Iterator;

public class AlphabeticalOrderIterator(WordCollection _collection, bool reverse) : Iterator
{
    private int _position = reverse ? _collection.GetItems().Count : -1;
    public override int Key()
    {
        return _position;
    }

    public override object Current()
    {
        return _collection.GetItems()[_position];
    }

    public override bool MoveNext()
    {
        int updatePos = _position + (reverse ? -1 : 1);
        if (updatePos >= 0 && updatePos < _collection.GetItems().Count)
        {
            _position = updatePos;
            return true;
        }

        return false;
    }

    public override void Reset()
    {
        _position = reverse ? _collection.GetItems().Count - 1 : 0;
    }
}
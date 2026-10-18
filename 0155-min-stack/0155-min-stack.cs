public class MinStack
{
    private int[] _items;
    private int _size;
    private const int _defaultLen = 4;
    private int[] _minItems;

    public MinStack()
    {
        _items = new int[_defaultLen];
        _minItems = new int[_defaultLen];
        _size = 0;
    }

    public void Push(int value)
    {
        if (_size == _items.Length)
        {
            Array.Resize(ref _items, _items.Length * 2);
            Array.Resize(ref _minItems, _minItems.Length * 2);
        }
        _items[_size] = value;

        if (_size == 0)
        {
            _minItems[_size] = value;
        }
        else
        {
            _minItems[_size] = Math.Min(value, _minItems[_size - 1]);
        }
        _size++;
        
    }

    public void Pop()
    {
        if (_size > 0)
        {
            _size--;
        }
        
    }

    public int Top()
    {
        if ( _size == 0)
        {
            return _items[_size];
        }
        return _items[_size - 1];
    }

    public int GetMin()
    {
        if ( _size == 0)
        {
            return _minItems[_size];
        }
        return _minItems[_size - 1];
    }
}
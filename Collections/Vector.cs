namespace Algorithms_CSharp.Collections;

public class Vector<T> : IEnumerable<T> 
{
    private T[] _items;
    private int _count;
    private int _capacity;

    public int Count => _count;
    public int Capacity => _capacity;

    public Vector()
    {
        _items = new T[4];
        _count = 0;
        _capacity = 0;
    }

    public void PushBack(T item)
    {
        if (_count == _capacity)
        {
            ResizeArray(_capacity * 2);
        }
        _items[_count++] = item;
    }

    public void PopBack()
    {
        if (_count == 0)
            throw new InvalidOperationException("Vector is empty");
        _items[--_count] = default!; //clear reference for GC
    }

    public T At(int index)
    {
        if (index < 0 || index >= _count)
            throw new IndexOutOfRangeException($"Index {index} is out of range");
        return _items[index];
    }

    public T this[int index]
    {
        get => At(index);
        set
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException($"Index {index} is out of range");
            _items[index] = value;
        }
    }

    public void Resize(int newSize)
    {
        if (newSize == _count) return;

        if (newSize < 0)
            throw new ArgumentOutOfRangeException(nameof(newSize), "Size cannot be negative");

        if (newSize > _capacity)
        {
            ResizeArray(Math.Max(newSize, _capacity * 2));
        }

        if (newSize > _count)
        {
            for (int i = _count; i < newSize; i++)
            {
                _items[i] = default!;
            }
        }
        else
        {
            for (int i = newSize; i < _count; ++i)
            {
                _items[i] = default!; //clear references for GC
            }
        }
            _count = newSize;
    }

    public void Reserve(int newCapacity)
    {
        if (newCapacity < 0)
            throw new ArgumentOutOfRangeException(nameof(newCapacity), "Capacity cannot be negative");
        if (newCapacity > _capacity)
        {
            ResizeArray(newCapacity);
        }
    }

    public void Clear()
    {
        for (int i = 0; i < _count; i++)
        {
            _items[i] = default!; //clear references for GC
        }
        _count = 0;
    }

    private void ResizeArray(int newCapacity)
    {
        T[] newArray = new T[newCapacity];
        for (int i = 0; i < _count; i++)
        {
            newArray[i] = _items[i];
        }
        _items = newArray;
        _capacity = newCapacity;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _count; i++)
        {
            yield return _items[i];
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}










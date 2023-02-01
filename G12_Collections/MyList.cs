namespace G12_Collections;

internal class MyList<T> : MyCollectionBase<T>, IList<T>
{
	public T this[int index] { get => _items[index]; set => _items[index] = value; }

	public void Add(T item)
	{
		AddItem(item);
	}

	public IEnumerable<int> IndexesOf(T item)
	{
        for (int i = 0; i < _count; i++)
        {
            if (item.Equals(_items[i]))
            {
				yield return i;
            }
        }
	}

	public void RemoveAll(T item)
	{
        for (int i = 0; i < _count; i++)
        {
            if (_items[i].Equals(item))
            {
				Remove(item);
            }
        }
	}

	public void Insert(int index, T item)
	{
		if (_count == _items.Length)
		{
			Resize(ref _items, _count, _items.Length + 1);
		}

		for (int i = _count; i > index; i--)
		{
			_items[i] = _items[i - 1];
		}
		_items[index] = item;
	}

	public int IndexOf(T item)
	{
		return IndexOf(item, 0);
	}

	public int IndexOf(object value, int startIndex)
	{
		for (int i = startIndex; i < _items.Length; i++)
		{
			if (_items[i].Equals(value))
				return i;
		}
		return -1;
	}

	public void RemoveAt(int index)
	{
		for (int i = index + 1; i < _count; i++)
		{
			_items[i - 1] = _items[i];
		}
	}
}

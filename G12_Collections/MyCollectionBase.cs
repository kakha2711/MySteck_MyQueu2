using System.Collections;

namespace G12_Collections;

internal abstract class MyCollectionBase<T> : ICollection<T>
{
	protected T[] _items;
	protected int _count;

	public MyCollectionBase()
	{
		_items = new T[4];
		_count = 0;
	}

	void ICollection<T>.Add(T item)
	{

	}

	protected void AddItem(T item)
	{
		if (_items.Length - 1 == _count)
		{
			Resize(ref _items, _items.Length * 2, _count);
		}

		_items[_count] = item;
		_count++;
	}

	public void Clear()
	{
		_items = new T[4];
		_count = 0;
	}

	public bool Contains(T item)
	{
		return IndexOf(item) != -1;
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

	public virtual IEnumerator<T> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return _items[i];
		}
	}

	public bool Remove(T item)
	{
		int index = IndexOf(item);
		if (index != -1)
		{
			RemoveAt(index);
		}
		return true;
	}

	public void RemoveAt(int index)
	{
		for (int i = index + 1; i < _count; i++)
		{
			_items[i - 1] = _items[i];
		}
		_count--;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		foreach (T item in _items)
		{
			yield return item;
		}
	}

	protected static void Resize(ref T[] array, int size, int count)
	{
		T[] Temp = new T[size];

		for (int i = 0; i < count; i++)
		{
			Temp[i] = array[i];
		}
		array = Temp;
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		for (int i = 0; i < Count; i++)
		{
			array.SetValue(_items[i], i + arrayIndex);
		}
	}

	public int Count { get => _count; }

	public bool IsReadOnly => true;

}

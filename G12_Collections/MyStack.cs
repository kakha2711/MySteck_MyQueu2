namespace G12_Collections;

internal class MyStack<T> : MyCollectionBase<T>
{
    public virtual T Peek()
    {
        return _items[_items.Count() - 1];
    }

    public virtual T Pop()
    {
        var element = _items[_items.Count() - 1];
        RemoveAt(_items.Count() - 1);
        return element;
    }

    public virtual void Push(T items)
    {
        AddItem(items);
    }

    public override IEnumerator<T> GetEnumerator()
    {
        for (int i = _count - 1; i >= 0; i--)
        {
            yield return _items[i];
        }
    }

}

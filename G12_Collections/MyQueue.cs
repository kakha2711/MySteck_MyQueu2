namespace G12_Collections;

internal class MyQueue<T> : MyCollectionBase<T>
{
    public virtual void Enqueue(T items)
    {
        AddItem(items);
    }

    public virtual T Dequeue()
    {
        var element = _items[0];
        RemoveAt(0);
        return element;
    }

    public virtual T Peek() => _items[_items.Count() - 1];
}

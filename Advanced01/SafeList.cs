namespace Advanced01;

internal class SafeList<T>
{
    private readonly List<T> _items = new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T? Get(int index)
    {
        if (index < 0 || index >= _items.Count)
        {
            return default;
        }

        return _items[index];
    }
}

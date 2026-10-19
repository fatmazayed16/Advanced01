using Advanced01.Interfaces;

namespace Advanced01;

internal class Repsitory<T> : IRepository<T> where T : IEntety
{
    private readonly List<T> _items = [];
    public void Add(T item)
    {
        _items.Add(item);
    }

    public List<T> GetAll()
    {
        return [.. _items];
    }

    public T? GetById(int id)
    {
        //for (int i = 0; i < _items.Count; i++)
        //{
        //    if (_items[i].Id == id)
        //    {
        //        return _items[i];
        //    }
        //}
        //return default;
        return _items.FirstOrDefault(item => item.Id == id);
    }

    public void Remove(int id)
    {
        T? item = GetById(id);
        if (item != null)
        {
            _items.Remove(item);
        }
    }

    public void Update(T item)
    {
        T? existingItem = GetById(item.Id);
        if (existingItem == null)
        {
            return;
        }
        int index = _items.IndexOf(existingItem);
        if (index >= 0)
        {
            _items[index] = item;
        }

    }
}

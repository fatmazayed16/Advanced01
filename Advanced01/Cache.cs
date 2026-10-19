namespace Advanced01;

internal class Cache <TKey, TValue>
{
    private readonly List<CacheItem<TKey, TValue>> _items = [];

    #region Add
    public void Add(TKey key, TValue value, TimeSpan expiration)
    {
        Remove(key);
        // Remove the old item if the key already exists.

        DateTime expirationTime = DateTime.UtcNow.Add(expiration);
        // Calculate the expiration time.

        _items.Add(new CacheItem<TKey, TValue>(
            key, value, expirationTime));
        // Create and add the new cache item.
    }

    #endregion

    #region Get

    public TValue? Get(TKey key)
    {
        for (int i = 0; i < _items.Count; i++)
        {
            // Find the item with the specified key.
            if (EqualityComparer<TKey>.Default.Equals(_items[i].Key, key))
            {
                // Remove the item if it has expired.
                if (DateTime.UtcNow >= _items[i].ExpirationTime)
                {
                    _items.RemoveAt(i);
                    return default;
                }

                return _items[i].Value;
            }
        }
        // Return the default value if the key is not found.
        return default;
    }

    #endregion

    #region Remove

    public bool Remove(TKey key)
    {
        for (int i = 0; i < _items.Count; i++)
        {
            // Find the item with the specified key
            if (EqualityComparer<TKey>.Default.Equals(_items[i].Key, key))
            {
                _items.RemoveAt(i);
                return true;
            }
        }

        return false;
        // Return false if the key is not found
    }

    #endregion

    #region Contains

    public bool Contains(TKey key)
    {
        for (int i = 0; i < _items.Count; i++)
        {
            // Find the item with the specified key.
            if (EqualityComparer<TKey>.Default.Equals(_items[i].Key, key))
            {
                // Remove the item if it expired.
                if (DateTime.UtcNow >= _items[i].ExpirationTime)
                {
                    _items.RemoveAt(i);
                    return false;
                }
                return true;
                // The item exists and is still valid>
            }
        }
        return false;
        // Return false if the key is not found.
    }

    #endregion
}
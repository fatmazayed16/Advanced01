namespace Advanced01;

internal class CacheItem<TKey ,TValue>
{
    public CacheItem(TKey key, TValue value, DateTime expirationTime)
    {
        Key = key;
        Value = value;
        ExpirationTime = expirationTime;
    }

    public TKey Key { get; set; }
    public TValue Value { get; set; }
    public DateTime ExpirationTime { get; set; }
}
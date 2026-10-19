namespace Advanced01;

internal class Pair<TValue, TKey>(TValue value, TKey key)
{
    public TValue Value { get; set; } = value;
    public TKey Key { get; set; } = key;
}

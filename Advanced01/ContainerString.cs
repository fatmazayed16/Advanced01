namespace Advanced01;

internal class ContainerString<T> where T : class
{
    public T Value { get; set; } = default!;
    public void Add(T a)
    {
        Value = a;
    }

    public T Get()
    {
        return Value;
    }
}

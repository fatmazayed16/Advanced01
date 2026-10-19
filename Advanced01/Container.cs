namespace Advanced01;

internal class Container<T>
{
    public T Value { get; set; } = default!;
    public void Add (T a)
    {
        Value = a;
    }

    public T Get ()
    {
        return Value;
    }
}

namespace Advanced01;

internal class Container<T> where T : struct
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

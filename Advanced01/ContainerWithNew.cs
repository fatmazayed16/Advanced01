namespace Advanced01;

internal class ContainerWithNew<T> where T : new()
{
    public T Create()
    {
        return new T();
    }
}

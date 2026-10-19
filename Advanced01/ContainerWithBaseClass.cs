namespace Advanced01;

internal class ContainerWithBaseClass <T> where T : Animal , new()
{
    public T Create()
    {
        return new T();
    }
}

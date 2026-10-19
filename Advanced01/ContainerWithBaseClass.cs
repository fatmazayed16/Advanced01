using Advanced01.Interfaces;

namespace Advanced01;

internal class ContainerWithBaseClass <T> where T : Animal, IEntety, new()
{
    public T Create()
    {
        return new T();
    }
}

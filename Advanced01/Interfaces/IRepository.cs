namespace Advanced01.Interfaces;

internal interface IRepository<T> where T : IEntety
{
    public void Add(T item);
    public List<T> GetAll();
    public T? GetById(int id);
    public void Remove(int id);
    public void Update(T item);
}

namespace Repositories.Contracts;

public interface IRepository<T>
{
    T GetOne(int id);
    void Post(T entity);
    void Delete(int id);
}
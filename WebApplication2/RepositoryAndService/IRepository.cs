namespace WebApplication2.RepositoryAndService
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<List<T>> getAll();
        Task<T> get(int id);
        Task<T> update(T entity);
        Task<T> delete(int id);
        Task<T> add(T entity);
    }
}

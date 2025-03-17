namespace CompanyAPI.DAL;

public interface IRepository<T>
{

    Task<List<T>> GetAllAsync();
    Task<T?> GetByIdAsync(Guid Id);
    T GetById(Guid Id);
    void Add(T entity);
    void Delete(T entity);
    int SaveChanges();

}

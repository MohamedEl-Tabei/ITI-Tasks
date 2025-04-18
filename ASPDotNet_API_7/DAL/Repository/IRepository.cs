using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApi.DAL;

public interface IRepository<T>
{
    public Task<List<T>> GetAllAsync();
    public Task<T?> GetByIdAsync(Guid id);
    public Task CreateAsync(T entity);
    public Task UpdateAsync(T entity);
    public void Delete(T entity);
}

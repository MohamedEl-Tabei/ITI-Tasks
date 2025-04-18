using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SocialMediaApi.DAL;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly MyContext _context;

    public Repository(MyContext context) => _context = context;

    #region Create
    public async Task CreateAsync(T entity) =>await _context.Set<T>().AddAsync(entity);
    #endregion
    #region Read
    public Task<List<T>> GetAllAsync() => _context.Set<T>().ToListAsync();

    public async Task<T?> GetByIdAsync(Guid id) => await _context.Set<T>().FindAsync(id);
    #endregion
    #region Update
    public async Task UpdateAsync(T entity) { }

    #endregion
    #region Delete
    public void Delete(T entity) => _context.Set<T>().Remove(entity);

    #endregion




}

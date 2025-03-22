using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_API_DAL;

public class UnitOfWork : IUnitOfWork
{
    private readonly ITIContext _context;
    public IRepoStudent Student { get; }
    public IRepoCourse Course { get; }

    public UnitOfWork(IRepoStudent student, IRepoCourse course,ITIContext context)
    {
        Student = student;
        Course = course;
        _context = context;
    }

    public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();

    public int SaveChanges() => _context.SaveChanges();

}

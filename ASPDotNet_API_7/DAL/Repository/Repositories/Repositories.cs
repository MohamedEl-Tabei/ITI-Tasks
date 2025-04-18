using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApi.DAL;

public class Repositories:IRepositories
{
    public IUserRepository? User { get; set; }

    private readonly MyContext _context;

    public Repositories(IUserRepository user,MyContext context)
    {
        User = user;
        _context=context;
    }
    public async Task<int> SaveChangesAsync()=>await _context.SaveChangesAsync();
}

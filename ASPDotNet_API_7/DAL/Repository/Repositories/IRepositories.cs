using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApi.DAL;

public interface IRepositories
{
    public IUserRepository? User { get; set; }


   
    public  Task<int> SaveChangesAsync();
}

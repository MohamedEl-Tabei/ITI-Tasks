using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApi.BL;

public interface IUserManager
{
    public Task<List<UserRead>> GetAllAsync();
    public Task<UserRead?> GetByIdAsync(Guid id);
    public Task<GeneralResult<UserCreate>> CreateAsync(UserCreate entity);
    public Task<GeneralResult<UserUpdate>> UpdateAsync(UserUpdate entity, Guid id);
    public void Delete(Guid id);
}

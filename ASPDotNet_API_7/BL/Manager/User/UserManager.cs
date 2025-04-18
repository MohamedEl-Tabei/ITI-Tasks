using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMediaApi.DAL;

namespace SocialMediaApi.BL;

public class UserManager : IUserManager
{
    private readonly IRepositories _repositories;
    private readonly UserCreateValidator _ValidatorCreate;
    private readonly UserUpdateValidator _ValidatorUpdate;

    public UserManager(IRepositories repositories, UserCreateValidator validatorCreate,UserUpdateValidator validatorUpdate)
    {
        _repositories = repositories;
        _ValidatorCreate = validatorCreate;
        _ValidatorUpdate=validatorUpdate;
    }
    public async Task<GeneralResult<UserCreate>> CreateAsync(UserCreate entity)
    {
        var validationResult = await _ValidatorCreate.ValidateAsync(entity);
        if (validationResult.IsValid)
        {
            var newUser = new User()
            {
                Email = entity.Email,
                Name = entity.Name,
                Password = entity.Password
            };
            await _repositories.User?.CreateAsync(newUser);
            await _repositories.SaveChangesAsync();
            return new GeneralResult<UserCreate>()
            {
                Success = true,
                generalErrors = [],
                Data = entity

            };
        }
        return new GeneralResult<UserCreate>()
        {
            Success = false,
            generalErrors = validationResult.Errors.Select(e => new GeneralError { Code = e.ErrorCode, Message = e.ErrorMessage }).ToArray(),
            Data = entity
        };
    }

    public void Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<UserRead>> GetAllAsync()
    {
        var users = await _repositories.User.GetAllAsync();
        return users.Select(u => new UserRead
        {
            Email = u.Email,
            Id = u.Id,
            Name = u.Name,
        }).ToList();
    }

    public Task<UserRead?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<GeneralResult<UserUpdate>> UpdateAsync(UserUpdate entity, Guid id)
    {
        var user=await _repositories.User.GetByIdAsync(id);
        var validationResult= await _ValidatorUpdate.ValidateAsync(entity);
        if (!validationResult.IsValid) throw new UserException(validationResult.Errors);

        user.Email= entity.Email;
        user.Name= entity.Name;
        user.Password= entity.Password;
        await _repositories.SaveChangesAsync();
        return new GeneralResult<UserUpdate>()
        {
            Success = true,
            Data = entity,
            generalErrors = []
        };
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using SocialMediaApi.BL.DTO.User;

namespace SocialMediaApi.BL;

public interface IUserManager
{
    public Task<List<UserRead>> GetAllAsync();
    public Task<Token> GenerateTokenAsync(List<Claim> claims);
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApi.DAL;

public class UserRepository:Repository<User>,IUserRepository
{
    public UserRepository(MyContext context):base(context){}
}

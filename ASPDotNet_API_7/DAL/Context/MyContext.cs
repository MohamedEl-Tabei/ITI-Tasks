using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SocialMediaApi.DAL;

public class MyContext : DbContext
{

    public MyContext(DbContextOptions<MyContext> options) : base(options) { }
    #region Tables
    public DbSet<User> Users { get; set; }

    #endregion

}

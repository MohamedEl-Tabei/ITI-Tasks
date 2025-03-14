using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_1.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_1.Context
{
    internal class MyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=EFLab1;trusted_Connection=true;trustServerCertificate=true;");
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department>  Departments { get; set; }
    }
}

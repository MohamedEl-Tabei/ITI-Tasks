using EF_2.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_2.Context
{
    internal class MyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=NewITI;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Course
            modelBuilder.Entity<Course>((c) =>
            {
                c.HasKey("Crs_Id");
                c.Property(c=>c.Crs_Name).HasMaxLength(50);
                c.HasOne(c => c.Topic).WithMany(t => t.Courses);
            });
            #endregion
            #region Ins_Course
            modelBuilder.Entity<Ins_Course>((c) =>
            {
                c.HasKey(c => new { c.crs_Id, c.Ins_Id });
            });
            #endregion
            #region Student
            modelBuilder.Entity<Student>(s =>
            {
                s.HasOne(s=>s.St_Super).WithMany(s=>s.StudentsNotSuper).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion
            #region Manager
            modelBuilder.Entity<Department>(d =>
            {
                d.HasOne(d => d.Manager).WithOne(m => m.MangedDepartment).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion
        }

        #region DbSet
        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Stud_Course> StudentCourse { get; set; }
        #endregion
    }
}

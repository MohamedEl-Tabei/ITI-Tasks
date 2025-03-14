using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_2.Models
{
    internal class Student
    {
        [Key]
        public int St_Id { get; set; }
        [StringLength(50)]
        public string? St_FName { get; set; }
        [StringLength(50)]
        public string? St_LName { get; set; }
        [StringLength(100)]
        public string? St_Address { get; set; }
        public int St_Age { get; set; }
        #region Department 
        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public Department Department { get; set; }
        #endregion
        #region st_Super
        [ForeignKey(nameof(Student))]
        public int St_SuperId {  get; set; }
        public virtual Student St_Super { get; set; }
        #endregion
        public virtual ICollection<Stud_Course> Stud_Courses { get; set; }=new HashSet<Stud_Course>();
        public virtual ICollection<Student> StudentsNotSuper { get; set; } =new HashSet<Student>();
    }
}

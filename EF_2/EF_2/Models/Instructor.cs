using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Models
{
    internal class Instructor
    {
        [Column("Ins_Id")]
        public int Id { get; set; }

        public string Ins_Name { get; set; }
        public int Ins_Degree { get; set; }
        public decimal Salary { get; set; }

        #region Department
        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public Department Department { get; set; }
        #endregion
        public Department MangedDepartment { get; set; }

        public ICollection<Ins_Course> ins_Courses { get; set; }
    }
}

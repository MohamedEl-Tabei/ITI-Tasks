using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Models
{
    internal class Department
    {
        [Column("Dept_Id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Dept_Name { get; set; }
        [StringLength(50)]
        public string Dept_Desc { get; set; }
        public string Dept_Location { get; set; }
        public DateTime Dept_HireDate { get; set; }
        #region Manager
        [ForeignKey(nameof(Instructor))]
        [Column("Dept_Manger")]
        public int ManagerId { get; set; }
        public virtual Instructor Manager { get; set; }
        #endregion

        public ICollection<Student> Students { get; set; } = new List<Student>();

    }
}

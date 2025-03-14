using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_2.Models
{
    [PrimaryKey("Crs_Id", "Stud_Id")]
    internal class Stud_Course
    {
        #region Course
        [ForeignKey("Course")]
        public int Crs_Id { get; set; }
        public virtual Course Course { get; set; }
        #endregion
        #region Student
        [ForeignKey("Student")]
        public int Stud_Id { get;set; }
        public virtual Student Student { get; set; }
        #endregion

        public int Grade {  get; set; }
    }
}

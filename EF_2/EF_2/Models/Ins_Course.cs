using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Models
{
    internal class Ins_Course
    {
        #region Instructor
        [ForeignKey("Instructor")]
        public int Ins_Id { get; set; }
        public Instructor Instructor { get; set; }
        #endregion
        #region Course
        [ForeignKey("Course")]
        public int crs_Id { get; set; }
        public Course Course { get; set; }
        #endregion
        public int Evalution { get; set; }
    }
}

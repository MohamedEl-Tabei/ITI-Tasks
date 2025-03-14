

using System.ComponentModel.DataAnnotations.Schema;

namespace EF_2.Models
{
    internal class Course
    {
        public int Crs_Id { get; set; }
        public string? Crs_Name { get; set; }

        public int Crs_Duration { get; set; }

        #region Topic
        [ForeignKey("Topic")]
        public int Topic_Id {  get; set; }
        public virtual Topic Topic { get; set; }
        #endregion

        public virtual ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();
        public ICollection<Ins_Course> ins_Courses { get; set; }
    }
}

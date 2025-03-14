
using System.ComponentModel.DataAnnotations;

namespace EF_2.Models
{
    internal class Topic
    {
        [Key]
        public int Top_Id { get; set; }
        [StringLength(50)]
        public string? Top_Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}

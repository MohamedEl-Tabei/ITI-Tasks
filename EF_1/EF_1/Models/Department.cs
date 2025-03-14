using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Models
{
    internal class Department
    {
        public int Id { get; set; }
        
        [MaxLength(25), MinLength(2)]
        public string Name { get; set; }
        public virtual HashSet<Student> Students { get; set; } = new HashSet<Student>();
        public Department(string name) {
            Name= name;
        }
        public override string ToString() => Name;
    }
}

using System.ComponentModel.DataAnnotations;

namespace ASPDotNet_MVC_1.Models;

public class AddStudentDTO
{
    [Required]
    public string Name { get; set; }
    [Required]
    [MinLength(2)]
    [MaxLength(3)]
    public string Department { get; set; }
    [DataType(DataType.EmailAddress)]
    [Required]
    public string Email { get; set; }
}

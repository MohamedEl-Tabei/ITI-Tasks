using FluentValidation;
using ITI_API_BL.DTO.Student;
using ITI_API_DAL;
using Microsoft.Extensions.Configuration;

namespace ITI_API_BL;

public class Validator : AbstractValidator<DTOStudentCreate>
{
    public Validator(IConfiguration configuration, IUnitOfWork unitOfWork)
    {

        RuleFor(s => s.Age).NotEmpty().WithMessage("Enter Age").Must(v=>v>23).WithMessage("Age must be more than 23");
        RuleFor(s => s.Name).NotEmpty().WithMessage("Enter Name").Must( (value, token) => unitOfWork.Student.GetAllWihCourses().All(s=>s.Name!=value.Name)).WithMessage("Name must be unique");

    }
}

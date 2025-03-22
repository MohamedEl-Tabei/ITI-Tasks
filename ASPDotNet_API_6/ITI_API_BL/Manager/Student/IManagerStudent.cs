using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI_API_BL.DTO;
using ITI_API_BL.DTO.Student;
using ITI_API_DAL;

namespace ITI_API_BL;

public interface IManagerStudent
{
    List<DTOStudentRead> GetAll();
    Task<DTOStudentRead> GetByIdAsync(Guid id);
    DTOStudentRead GetById(Guid id);
    void Update(Guid id,DTOStudentCreate newData);

    void Delete(Guid id);
    GeneralResult<DTOStudentCreate> Add(DTOStudentCreate studentCreated);

}

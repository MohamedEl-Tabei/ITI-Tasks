using ITI_API_BL;
using ITI_API_BL.DTO.Student;
using ITI_API_DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ITI_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IManagerStudent _manager;
        public StudentController(IManagerStudent manager) =>_manager=manager;
        [HttpGet]
        [ServiceFilter(typeof(FilterPrintArguements))]
        public  Ok<List<DTOStudentRead>> GetAllAsync()=> TypedResults.Ok( _manager.GetAll());
        [HttpGet("{id}")]
        [ServiceFilter(typeof(FilterPrintArguements))]

        public Results<Ok<DTOStudentRead>,NotFound> GetById(Guid id)
        {
            var student=  _manager.GetById(id);
            if (student is null) return TypedResults.NotFound();
            return TypedResults.Ok(student);
        }
        [HttpPost]
        public NoContent Add(DTOStudentCreate newData)
        {
            _manager.Add(newData);
            return TypedResults.NoContent();
        }
        [HttpDelete("{id}")]
        public Results<NoContent, NotFound> Delete(Guid id)
        {
            var student = _manager.GetById(id);
            if (student is null) return TypedResults.NotFound();
            _manager.Delete(id);
            return TypedResults.NoContent();
        }
        [HttpPut("{id}")]
        [ServiceFilter(typeof(FilterPrintArguements))]
        public Results<NoContent, NotFound> Update(Guid id,DTOStudentCreate newData)
        {
            var student = _manager.GetById(id);
            if (student is null) return TypedResults.NotFound();
            _manager.Update(id,newData);
            return TypedResults.NoContent();
        }
    }
}

using ITI_API_BL;
using ITI_API_DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ITI_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IManagerCourse _manager;
        public CourseController(IManagerCourse manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public Ok<List<Course>> GetAll()=> TypedResults.Ok( _manager.GetAll());
    }
}

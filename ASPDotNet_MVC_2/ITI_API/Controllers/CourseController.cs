using ITI_API_BL;
using ITI_API_BL.DTO;
using ITI_API_DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ITI_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IManagerCourse _manager;
        private readonly MyOptions _options;

        public CourseController(IManagerCourse manager, IOptions<MyOptions> options)
        {
            _manager = manager;
            _options=options.Value;
        }

        [HttpGet]
        public Ok<List<Course>> GetAll()
        {
           return TypedResults.Ok(_manager.GetAll());
        }
    }
}

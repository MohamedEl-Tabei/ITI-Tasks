using ASPDotNet_MVC_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNet_MVC_1.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> _students = Student.GetStudents();
        public IActionResult Index()
        {
            return View(_students);
        }
        [HttpGet]
        public IActionResult Details(Guid id)
        {
            return View(_students.Find(s => s.Id == id));
        }
        [HttpGet]
        public IActionResult AddStudent()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(AddStudentDTO student)
        {
            if (!ModelState.IsValid) return View(student);
            _students.Add(new Student { Department = student.Department, Email = student.Email, Name = student.Name, Id = Guid.NewGuid() });
            return RedirectToAction("Index");
        }
    }
}

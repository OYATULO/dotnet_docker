using fordocker.Models;
using fordocker.Services;
using Microsoft.AspNetCore.Mvc;

namespace fordocker.Controllers
{
    public class StudentController : Controller
    {

            IStudentService _studentService = null;
       
            public StudentController (IStudentService studentService)
            {
                _studentService = studentService;
            }
            public IActionResult Index()
            {
                return View();
            }
            public List<Students> GetStudents(string name)
            {
                return _studentService.GetStudents(name);
            }
            public void SaveOrUpdate(Students student)
            {
                _studentService.SaveOrUpdate(student);
            }
            public void Delete(int id)
            {
                _studentService.Delete(id);
            }

    }
}

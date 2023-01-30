using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        IStudenService _studentService = null;

        public StudentController(IStudenService studentService)
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
            _studentService.SavaOrUpdate(student);
        }
        public void Delete(int studentid) 
        { 
        _studentService.Delete(studentid);
        }
    }
}

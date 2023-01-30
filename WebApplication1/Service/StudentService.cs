using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Service
{
    public class StudentService : IStudenService
    {
        DataContext _dataContext = null;

        public StudentService(DataContext dataContext) {
            _dataContext = dataContext;
        }
        public void Delete(int studentid)
        {
            _dataContext.Database.ExecuteSqlRaw($"DELETEStudents {studentid}");
        }

        public List<Students> GetStudents(string name)
        {
            var students = _dataContext._Students.FromSqlRaw($"GetstudentName {name}").ToList();
            return students;
        }

        public void SavaOrUpdate(Students students)
        {
            _dataContext.Database.ExecuteSqlRaw($"SaveORUpdate {students.StudentID},{students.Name},{students.Age}");

            //test
            var getstudent = _dataContext._Students.ToList();

        }
    }
}

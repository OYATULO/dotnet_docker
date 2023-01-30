using fordocker.Context;
using fordocker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fordocker.Services
{
    public class StudentService : IStudentService
    {
        DatabaseContext _databaseContext = null;

        public StudentService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public List<Students> GetStudents(string name)
        {
            var students = _databaseContext.Students.FromSqlRaw($"GetstudentName {name}").ToList();
            return students;
        }
        
        public void SaveOrUpdate(Students student)
        {
            _databaseContext.Database.ExecuteSqlRaw($"SaveORUpdate {student.StudentID}, {student.Name}, {student.Age} ");
            //test 
            var getstudent = _databaseContext.Students.ToList();
        }
        public void Delete(int studentID)
        {
            _databaseContext.Database.ExecuteSqlRaw($"DELETEStudents {studentID}");
        }
    }
}

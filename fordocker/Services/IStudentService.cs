using fordocker.Models;

namespace fordocker.Services
{
    public interface IStudentService
    {
        List<Students> GetStudents(string name);
        void SaveOrUpdate(Students student);
        void Delete(int studentID);
    }
}

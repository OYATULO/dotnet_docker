using WebApplication1.Models;

namespace WebApplication1.Service
{
    public interface IStudenService
    {
        List<Students> GetStudents(string name);
        void SavaOrUpdate(Students students);
        void Delete(int studentid);
    }
}

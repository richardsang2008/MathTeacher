using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IStudentService
    {
        Task<Student> GetStudentByIdAsync(int studentId);
    }
}
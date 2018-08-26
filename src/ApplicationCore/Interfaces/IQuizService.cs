using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IQuizService
    {
        Task<Quiz> CreateQuizAsync(int QuizTypeId, int studentId);
    }
}
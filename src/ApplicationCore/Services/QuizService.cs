using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Services
{
    public class QuizService : IQuizService
    {
        private readonly IAsyncRepository<Quiz> _quizRepository;
        private readonly IAsyncRepository<Student> _studentRepository;

        public QuizService(IAsyncRepository<Quiz> quizRepository, IAsyncRepository<Student> studentRepository)
        {
            _quizRepository = quizRepository;
            _studentRepository = studentRepository;
        }

        public async Task<Quiz> CreateQuizAsync(int QuizTypeId, int studentId)
        {
            if (studentId > 0 && QuizTypeId > 0)
            {
                return null;
            }
            //locate the studentId
            var student = _studentRepository.GetByIdAsync(studentId);
            

            throw new System.NotImplementedException();
        }
    }
}
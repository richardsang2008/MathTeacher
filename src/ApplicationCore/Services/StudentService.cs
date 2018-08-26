using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Ardalis.GuardClauses;

namespace ApplicationCore.Services
{
    public class StudentService  :IStudentService
    {
        private readonly IAsyncRepository<Student> _studentRepository;
        private readonly IAppLogger<StudentService> _logger;

        public StudentService(IAsyncRepository<Student> studnetRepository, IAppLogger<StudentService> logger)
        {
            _studentRepository = studnetRepository;
            _logger = logger;
        }
        
        public async Task<Student> GetStudentByIdAsync(int studentId)
        {
            if (studentId <= 0)
            {
                var str = $"StudentId input {studentId} is less than 0. This is not allowed";
                _logger.LogInformation(str);
                throw new ValidationException(str);
            }

            var studnet = await _studentRepository.GetByIdAsync(studentId);
            Guard.Against.NullOrEmpty(studnet.FirstName,nameof(studnet));
            return studnet;

        }
    }
}
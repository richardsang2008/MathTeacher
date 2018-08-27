using System;
using System.IO.MemoryMappedFiles;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Ardalis.GuardClauses;

namespace ApplicationCore.Services
{
    public class QuizService : IQuizService
    {
        private readonly IAsyncRepository<Quiz> _quizRepository;
        private readonly IAsyncRepository<Student> _studentRepository;
        private readonly IAsyncRepository<QuizItem> _quizItemRepository;

        public QuizService(IAsyncRepository<Quiz> quizRepository, IAsyncRepository<Student> studentRepository, IAsyncRepository<QuizItem> quizItemRepository)
        {
            _quizRepository = quizRepository;
            _studentRepository = studentRepository;
            _quizItemRepository = quizItemRepository;
        }

        private void GenerateOperands(Operator opp, out int leftop, out int rightop )
        {
            Random random = new Random();
            var number1 = random.Next(1, 100000);
            var number2 = random.Next(1, 100000);
            leftop = number1;
            rightop = number2;
            if (rightop > leftop)
            {
                leftop = number2;
                rightop = number1;
            }
        }

        public async Task<Quiz> CreateQuizAsync(int quizTypeId, int studentId)
        {
            if (studentId > 0 && quizTypeId > 0)
            {
                return null;
            }
            //locate the studentId
            var student = _studentRepository.GetByIdAsync(studentId);
            Guard.Against.Null( student,nameof(student));
            //generate a daily quiz based on the quiz type
            var operatorr = Operator.Addition;
            if (quizTypeId == (int) Operator.Addition)
            {
                operatorr = Operator.Addition;
            } else if (quizTypeId == (int) Operator.Subtraction)
            {
                operatorr = Operator.Subtraction;
            } else if (quizTypeId == (int) Operator.Multiplication)
            {
                operatorr = Operator.Multiplication;
            }
            else
            {
                operatorr = Operator.Division;
            }

            int leftOp = 0;
            int rightOp = 0;
            GenerateOperands(operatorr, out leftOp, out rightOp );
            //create a quiz item
            //locate the lasted quizid
            
            var quizeItem = new QuizItem { };
            throw new System.NotImplementedException();
        }
    }
}
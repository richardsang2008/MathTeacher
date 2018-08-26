using System;
using System.Collections.Generic;
using System.Linq;
using ApplicationCore.Entities;

namespace Infrastructure.Data
{
    public class DbInitializer
    {
        public static void Initialize(QuizDbContext context)
        {
            //ensure the context.Database.EnsureCreated();
            context.Database.EnsureCreated();
            //Look for any students 
            if (context.Students.Any())
            {
                return; //db has been seeded
            }

            var students = new[]
            {
                new Student
                {
                    FirstName = "Joy", LastName = "Sang", MidName = "Jiayue",
                    EnrollmentDate = DateTime.Parse("2018-8-24"), Id = 1
                },
            };
            int studentId = 0;
            foreach (Student s in students)
            {
                context.Students.Add(s);
                studentId = s.Id;
            }

            context.SaveChanges();
            var quizTypes = new[]
            {
                new QuizType {Id = 1, Type = Operator.Addition.ToString()},
                new QuizType {Id = 2, Type = Operator.Subtraction.ToString()},
                new QuizType {Id = 3, Type = Operator.Multiplication.ToString()},
                new QuizType {Id = 4, Type = Operator.Division.ToString()},
            };
            foreach (QuizType s in quizTypes)
            {
                context.QuizTypes.Add(s);
            }

            context.SaveChanges();
            //generate 10 addtion
            Random random = new Random();
            var quiz = new Quiz
            {
                Id = 1,
                QuizTypeId = (int)Operator.Addition,
                QuizScore = 0,
                StudentId = studentId,
                QuizItems = new List<QuizItem>()
            };
            for (int i = 0; i < 10; i++)
            {
                decimal number1 = random.Next(1, 10000);
                decimal number2 = random.Next(1, 10000);
                var quizItem = new QuizItem()
                {
                    Id = i + 1, LeftOperand = number1, RightOperand = number2, Operator = Operator.Addition,
                    Answer = number1 + number2
                };
                context.QuizItems.Add(quizItem);
                quiz.QuizItems.Add(quizItem);
            }

            context.Quizes.Add(quiz);
            context.SaveChanges();
        }
    }
}
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class QuizDbContext :DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
        {
        }
        public DbSet<Quiz> Quizes { get; set; }
        public DbSet<QuizItem> QuizItems { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<QuizType> QuizTypes { get; set; }

    }
}
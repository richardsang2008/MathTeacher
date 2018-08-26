using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Infrastructure.Data
{
    public class EfRepository<T> :IRepository<T>, IAsyncRepository<T> where T: BaseEntity
    {
        protected readonly QuizDbContext _quizDbContext;

        public EfRepository(QuizDbContext quizDbContext)
        {
            _quizDbContext = quizDbContext;
        }

        public T GetBy(int id)
        {
            throw new System.NotImplementedException();
        }

        public T GetSingleBySpec(ISpecification<T> spec)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> ListAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> List(ISpecification<T> spec)
        {
            throw new System.NotImplementedException();
        }

        public T Add(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _quizDbContext.Set<T>().FindAsync(id);
        }

        public Task<List<T>> ListAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<T>> ListAsync(ISpecification<T> spec)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> AddAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
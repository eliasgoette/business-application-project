using System.Linq.Expressions;

namespace BusinessApplicationProject.Repository
{
    public interface IRepository<T> where T : class
    {
        //T? GetById(int id);
        List<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> searchTerm);
        Task AddAsync(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}
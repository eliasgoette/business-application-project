using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;
using System.Linq.Expressions;

namespace BusinessApplicationProject.Controller
{
    public class Controller<T> where T : class
    {
        public delegate AppDbContext AppDbContextFactory();
        public delegate Repository<T> RepositoryFactory(AppDbContext context);

        public AppDbContextFactory getContext { get; init; }
        public RepositoryFactory getRepository { get; init; }

        public List<T> GetAll()
        {
            List<T> result = new List<T>();

            using (var context = getContext())
            {
                var repository = getRepository(context);
                result = repository.GetAll();
            }

            return result;
        }

        public List<T> Find(Expression<Func<T, bool>> condition)
        {
            List<T> result = new List<T>();

            using (var context = getContext())
            {
                var repository = getRepository(context);
                result = repository.Find(condition).ToList();
            }

            return result;
        }

        public T? FindSingle(Expression<Func<T, bool>> condition)
        {
            T? result = null;

            using(var context = getContext())
            {
                var repository = getRepository(context);
                result = repository.Find(condition).FirstOrDefault();
            }

            return result;
        }

        public async Task AddAsync(T newItem) {
            using (var context = getContext())
            {
                var repository = getRepository(context);
                await repository.AddAsync(newItem);
            }
        }

        public void Remove(T item) {
            using (var context = getContext())
            {
                var repository = getRepository(context);
                repository.Remove(item);
            }
        }

        public void Update(T item) {
            using (var context = getContext())
            {
                var repository = getRepository(context);
                repository.Update(item);
            }
        }
    }
}
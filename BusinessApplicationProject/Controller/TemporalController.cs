using BusinessApplicationProject.Repository;
using System.Linq.Expressions;

namespace BusinessApplicationProject.Controller
{
    class TemporalController<T> : Controller<T> where T : class
    {
        // Make the repository temporal (also has inherited capabilities from normal repository)
        public delegate TemporalRepository<T> RepositoryFactory(AppDbContext context);
        public RepositoryFactory getRepository { get; init; }

        public List<T> FindAsOf(DateTime timestamp, Expression<Func<T, bool>> condition)
        {
            List<T> result = new List<T>();

            using (var context = getContext())
            {
                var repository = getRepository(context);
                result = repository.FindAsOf(timestamp, condition).ToList();
            }

            return result;
        }
    }
}

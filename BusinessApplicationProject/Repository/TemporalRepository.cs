using Microsoft.EntityFrameworkCore;

namespace BusinessApplicationProject.Repository
{
    public class TemporalRepository<T> : Repository<T>, ITemporalRepository<T> where T : class
    {
        public TemporalRepository(AppDbContext context) : base(context) { }

        public IEnumerable<T> GetAllAsOf(DateTime timestamp)
        {
            return Context.Set<T>().TemporalAsOf(timestamp);
        }

        public IEnumerable<T> GetWhereAsOf(DateTime timestamp, Func<T, bool> condition)
        {
            return Context.Set<T>().TemporalAsOf(timestamp).Where<T>(condition);
        }
    }
}
using Microsoft.EntityFrameworkCore;

namespace BusinessApplicationProject.Repository
{
    public class TemporalRepository<T> : Repository<T>, ITemporalRepository<T> where T : class
    {
        public TemporalRepository(AppDbContext context) : base(context) { }

        public IEnumerable<T> GetDataAsOf(DateTime timestamp)
        {
            return Context.Set<T>().TemporalAsOf(timestamp);
        }
    }
}
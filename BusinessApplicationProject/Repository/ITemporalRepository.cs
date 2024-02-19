namespace BusinessApplicationProject.Repository
{
    public interface ITemporalRepository<T> : IRepository<T> where T : class
    {
        public IEnumerable<T> GetAllAsOf(DateTime timestamp);

        public IEnumerable<T> GetWhereAsOf(DateTime timestamp, Func<T, bool> condition);
    }
}
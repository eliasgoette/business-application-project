namespace BusinessApplicationProject.Repository
{
    public interface ITemporalRepository<T> : IRepository<T> where T : class
    {
        public IEnumerable<T> GetDataAsOf(DateTime timestamp);
    }
}
namespace BusinessApplicationProject.Repository
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}

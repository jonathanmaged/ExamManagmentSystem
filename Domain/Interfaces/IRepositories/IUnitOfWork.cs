namespace Domain.Interfaces.IRepositories
{
    public interface IUnitOfWork:IDisposable
    {
        Task<int> Save();
    }
}

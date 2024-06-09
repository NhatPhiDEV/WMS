using WMS.Infrastructure.Repositories.Core;

namespace WMS.Infrastructure.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> GetRepository<TEntity>()
            where TEntity : class;

        int Commit();

        Task<int> CommitAsync();    
    }
}

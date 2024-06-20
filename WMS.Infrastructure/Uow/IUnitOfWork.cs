using WMS.Infrastructure.Repositories.Core;

namespace WMS.Infrastructure.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> GetRepository<TEntity>()
            where TEntity : class;

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        Task BeginTransaction();
        Task CommitTransaction();
        Task RollbackTransaction();

    }
}

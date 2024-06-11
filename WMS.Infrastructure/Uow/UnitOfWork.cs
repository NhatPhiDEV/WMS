using WMS.Infrastructure.EFContext;
using WMS.Infrastructure.Repositories.Core;

namespace WMS.Infrastructure.Uow
{
    public class UnitOfWork(AppDbContext context) : IUnitOfWork
    {
        private readonly Dictionary<Type, object> _repositories = [];

        public IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            var type = typeof(TEntity);

            if (!_repositories.TryGetValue(type, out var repository))
            {
                repository = new GenericRepository<TEntity>(context);
                _repositories[type] = repository;
            }

            return (IGenericRepository<TEntity>)repository;
        }

        public int Commit()
        {
            return context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await context.SaveChangesAsync(cancellationToken);
        } 

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

    }
}

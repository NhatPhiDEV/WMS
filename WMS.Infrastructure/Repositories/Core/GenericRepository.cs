using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WMS.Infrastructure.EFContext;

namespace WMS.Infrastructure.Repositories.Core;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly AppDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>>? predicate, params string[]? includes)
    {
        var query = _dbSet.AsNoTracking();

        if (includes != null && includes.Length != 0)
        {
            // Có include các thành phần liên quan
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }

        if (predicate != null)
        {
            return query.Where(predicate);
        }

        return query;
    }

    public IQueryable<TEntity> GetQueryable()
    {
        return _dbSet.AsQueryable();
    }


    public async Task<List<TResult>> GetMultipleAsync<TResult>(
        Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>>? predicate,
        CancellationToken cancellationToken = default,
        params string[]? includes)
    {
        var query = _dbSet.AsNoTracking();

        if (includes != null && includes.Length != 0)
        {
            // Có include các thành phần liên quan
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }

        if (predicate != null)
        {
            return await query.Where(predicate)
                .Select(selector)
                .ToListAsync(cancellationToken)
                .ConfigureAwait(false);
        }

        return await query.Select(selector)
            .ToListAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<TResult?> GetSingle<TResult>(
        Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        var queryable = _dbSet.AsNoTracking().Where(predicate).Select(selector);

        //var queryString = queryable.ToQueryString();

        return await queryable.FirstOrDefaultAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task<TEntity?> GetSingle(
        Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        var queryable = _dbSet.AsNoTracking().Where(predicate);
        return await queryable.FirstOrDefaultAsync(cancellationToken).ConfigureAwait(false);

    }

    public async Task<TResult?> GetSingle<TResult>
    (
        Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default,
        params string[] includes)
    {
        var query = _dbSet.AsNoTracking();

        if (includes.Length != 0)
        {
            // Có include các thành phần liên quan
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }

        return await query.Where(predicate)
            .Select(selector)
            .FirstOrDefaultAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    public void Create(TEntity entity)
    {
        _dbSet.Add(entity);
    }

    public void Update(TEntity entity)
    {
        var entityEntry = _context.Entry(entity);

        if (entityEntry.State == EntityState.Detached)
        {
            Detach(entity);
            _dbSet.Attach(entity);
        }

        entityEntry.State = EntityState.Modified;
    }

    public void Delete(TEntity entity)
    {
        _dbSet.Remove(entity);
    }

    private void Detach(TEntity entity)
    {
        var primaryKey = _dbSet.EntityType.FindPrimaryKey();

        if (primaryKey?.Properties.Count > 0)
        {
            var primaryKeyProperty = primaryKey.Properties[0];
            var primaryKeyVal = entity.GetType().GetProperty(primaryKeyProperty.Name)?.GetValue(entity, null);

            if (primaryKeyVal != null)
            {
                var existingEntityInDb = _dbSet.Find(primaryKeyVal);
                if (existingEntityInDb != null)
                {
                    _context.Entry(existingEntityInDb).State = EntityState.Detached;
                }
            }
        }
    }
}

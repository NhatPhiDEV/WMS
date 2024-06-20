using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WMS.Domain.Shared.Pagination;
using WMS.Domain.Shared.QueryParams;
using WMS.Infrastructure.EFContext;
using WMS.Infrastructure.Extensions;

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

    public async Task<List<TResult>> GetMultipleAsync<TResult>(
        Expression<Func<TEntity, TResult>> selector,
        CancellationToken cancellationToken = default)
    {
        var query = _dbSet.AsNoTracking();

        return await query.Select(selector)
            .ToListAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<TEntity?> FindByIdAsync(object id, CancellationToken cancellation)
    {
        return await _dbSet.FindAsync(id, cancellation);
    }

    public async Task<List<TResult>> GetMultipleAsync<TResult>(
        Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default,
        params string[] includes)
    {
        var query = _dbSet.AsNoTracking();

        if (includes.Length != 0)
        {
            query = includes.Aggregate(query, (current, include) => current.Include(include));
        }

        return await query.Where(predicate)
            .Select(selector)
            .ToListAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<TResult?> GetSingle<TResult>(
        Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        var queryable = _dbSet.AsNoTracking()
            .Where(predicate)
            .Select(selector);

        return await queryable
            .FirstOrDefaultAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<TEntity?> GetSingle(
        Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        var queryable = _dbSet.AsNoTracking()
            .Where(predicate);

        return await queryable
            .FirstOrDefaultAsync(cancellationToken)
            .ConfigureAwait(false);

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
            query = includes.Aggregate(query, (current, include) => current.Include(include));
        }

        return await query.Where(predicate)
            .Select(selector)
            .FirstOrDefaultAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    public IQueryable<TEntity> Sorting(IQueryable<TEntity> queryable, string? sortColumn, string? sortOrder)
    {
        throw new NotImplementedException();
    }

    public async Task<IPagedList<TResult>> GetPagedListAsync<TResult>(QueryOptions<TEntity, TResult> options)
    {
        var queryable = _dbSet.AsNoTracking();

        // has filter
        if (options.Predicate != null)
        {
            queryable = queryable.Where(options.Predicate);
        }

        // has includes
        if (options.Includes != null)
        {
            queryable = options.Includes.Aggregate(queryable, (current, include) => current.Include(include));
        }

        // has order by
        if (options.OrderBy != null)
        {
            queryable = options.OrderByDescending
                ? queryable.OrderByDescending(options.OrderBy)
                : queryable.OrderBy(options.OrderBy);
        }

        return await queryable
            .Select(options.Selector)
            .ToPagedListAsync(options.Page, options.PageSize);
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

    public void Delete(object id)
    {
        var entity = _dbSet.Find(id);

        if (entity != null)
        {
            Delete(entity);
        }
    }

    private void Detach(TEntity entity)
    {
        var primaryKey = _dbSet.EntityType.FindPrimaryKey();

        if (!(primaryKey?.Properties.Count > 0)) return;

        var primaryKeyProperty = primaryKey.Properties[0];
        var primaryKeyVal = entity.GetType().GetProperty(primaryKeyProperty.Name)?.GetValue(entity, null);

        if (primaryKeyVal == null) return;

        var existingEntityInDb = _dbSet.Find(primaryKeyVal);
        if (existingEntityInDb != null)
        {
            _context.Entry(existingEntityInDb).State = EntityState.Detached;
        }
    }
}

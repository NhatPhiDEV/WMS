using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WMS.Infrastructure.EFContext;

namespace WMS.Infrastructure.Repositories.Core;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public T? GetById<TKey>(TKey id)
    {
        return _dbSet.Find(id);
    }

    public IQueryable<TResult> FindBy<TResult>(
        Expression<Func<T, TResult>> selector,
        Expression<Func<T, bool>>? predicate,
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
            return query.Where(predicate).Select(selector);
        }

        return query.Select(selector);
    }

    public IQueryable<T> FindBy(Expression<Func<T, bool>>? predicate, params string[]? includes)
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

    public void Create(T entity)
    {
        _dbSet.Add(entity);
    }

    public void Update(T entity)
    {
        var entityEntry = _context.Entry(entity);

        if (entityEntry.State == EntityState.Detached)
        {
            Detach(entity);
            _dbSet.Attach(entity);
        }

        entityEntry.State = EntityState.Modified;
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    private void Detach(T entity)
    {
        var primaryKey = _dbSet.EntityType.FindPrimaryKey();

        if (primaryKey?.Properties.Count > 0)
        {
            var primaryKeyProperty = primaryKey.Properties[0];
            var primaryKeyValue = entity.GetType().GetProperty(primaryKeyProperty.Name)?.GetValue(entity, null);

            // Kiểm tra null trước khi sử dụng
            if (primaryKeyValue != null)
            {
                var existingEntityInDb = _dbSet.Find(primaryKeyValue);
                if (existingEntityInDb != null)
                {
                    _context.Entry(existingEntityInDb).State = EntityState.Detached;
                }
            }
        }
    }
}

using System.Linq.Expressions;

namespace WMS.Infrastructure.Repositories.Core;

public interface IGenericRepository<TEntity> where TEntity : class
{
    IQueryable<TEntity> FindBy(
        Expression<Func<TEntity, bool>>? predicate,
        params string[]? includes);

    IQueryable<TEntity> GetQueryable();

    Task<List<TResult>> GetMultipleAsync<TResult>(
        Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>>? predicate,
        CancellationToken cancellationToken = default,
        params string[]? includes);

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="selector"></param>
    /// <param name="predicate"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<TResult?> GetSingle<TResult>(
        Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default);

    Task<TEntity?> GetSingle(
        Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="selector"></param>
    /// <param name="predicate"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="includes"></param>
    /// <returns></returns>
    Task<TResult?> GetSingle<TResult>(
        Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default,
        params string[] includes);

    void Create(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
}

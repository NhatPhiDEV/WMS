using System.Linq.Expressions;
using WMS.Domain.Shared.Pagination;
using WMS.Domain.Shared.QueryParams;

namespace WMS.Infrastructure.Repositories.Core;

public interface IGenericRepository<TEntity> where TEntity : class
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="selector"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<List<TResult>> GetMultipleAsync<TResult>(
        Expression<Func<TEntity, TResult>> selector,
        CancellationToken cancellationToken = default);

    Task<TEntity?> FindByIdAsync(object id, CancellationToken cancellation);

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="selector"></param>
    /// <param name="predicate"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="includes"></param>
    /// <returns></returns>
    Task<List<TResult>> GetMultipleAsync<TResult>(
        Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default,
        params string[] includes);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="predicate"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
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
    /// <returns></returns>
    Task<TResult?> GetSingle<TResult>(
        Expression<Func<TEntity, TResult>> selector,
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

    IQueryable<TEntity> Sorting(IQueryable<TEntity> queryable, string? sortColumn, string? sortOrder);
    Task<IPagedList<TResult>> GetPagedListAsync<TResult>(QueryOptions<TEntity, TResult> options);

    void Create(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    void Delete(object id);
}

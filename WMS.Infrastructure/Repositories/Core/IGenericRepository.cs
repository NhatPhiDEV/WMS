using System.Linq.Expressions;

namespace WMS.Infrastructure.Repositories.Core;

public interface IGenericRepository<T> where T : class
{
    T? GetById<TKey>(TKey id);

    IQueryable<TResult> FindBy<TResult>(
        Expression<Func<T, TResult>> selector,
        Expression<Func<T, bool>>? predicate,
        params string[]? includes);

    IQueryable<T> FindBy(
        Expression<Func<T, bool>>? predicate,
        params string[]? includes);

    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}

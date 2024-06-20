using System.Linq.Expressions;

namespace WMS.Domain.Shared.QueryParams;

public record QueryOptions<TEntity, TResult>
{
    public required Expression<Func<TEntity, TResult>> Selector { get; set; }
    public Expression<Func<TEntity, bool>>? Predicate { get; set; } = null;
    public string[]? Includes { get; set; } = null;
    public CancellationToken CancellationToken { get; set; } = default;
    public Expression<Func<TEntity, object>>? OrderBy { get; set; } = null;
    public bool OrderByDescending { get; set; } = false;
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}
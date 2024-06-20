using Microsoft.EntityFrameworkCore;
using WMS.Domain.Shared.Pagination;

namespace WMS.Infrastructure.Extensions;

public static class PagedListExtensions
{
    public static async Task<IPagedList<T>> ToPagedListAsync<T>(this IQueryable<T> query, int page, int pageSize)
    {
        var totalCount = await query.CountAsync();
        var items = await query
            .Skip((page - 1) * pageSize)
            .Take(pageSize).ToListAsync();

        return new PagedList<T>(items, page, pageSize, totalCount);
    }
}
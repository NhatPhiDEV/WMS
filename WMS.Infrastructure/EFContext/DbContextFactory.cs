using Microsoft.EntityFrameworkCore;

namespace WMS.Infrastructure.EFContext;

public class DbContextFactory(DbContextOptions<AppDbContext> options) : IDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext()
    {
        return new AppDbContext(options);
    }
}
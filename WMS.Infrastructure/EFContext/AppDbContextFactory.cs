using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using WMS.Infrastructure.Common;

namespace WMS.Infrastructure.EFContext
{
    /// <summary>
    /// Hàm này phục vụ viện Migrate Database
    /// </summary>
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseSqlServer(AppConfig.Database.GetConnectionString());

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WMS.Infrastructure.Common;
using WMS.Infrastructure.EFContext;
using WMS.Infrastructure.Uow;

namespace WMS.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(AppConfig.GetConnectionString()));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}

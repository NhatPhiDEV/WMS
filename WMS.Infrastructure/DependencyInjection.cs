using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using S7.Net;
using WMS.Infrastructure.Common;
using WMS.Infrastructure.EFContext;
using WMS.Infrastructure.Excel;
using WMS.Infrastructure.PLC;
using WMS.Infrastructure.Uow;

namespace WMS.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {

            services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(AppConfig.Database.GetConnectionString()));

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<DbContextFactory>();

            services.AddScoped<IS7PlcClient, S7PlcClient>(provider => new S7PlcClient(AppConfig.Plc.IpAddress,
                CpuType.S71200,
                AppConfig.Plc.Rack,
                AppConfig.Plc.Slot));

            services.AddScoped<IExcelService, ExcelService>();


            return services;
        }
    }
}

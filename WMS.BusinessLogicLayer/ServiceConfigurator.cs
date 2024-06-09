using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WMS.BusinessLogic.Services.Inventories;
using WMS.BusinessLogic.Services.InventoryTransactions;
using WMS.BusinessLogic.Services.InventoryTransactionTypes;
using WMS.BusinessLogic.Services.Locations;
using WMS.BusinessLogic.Services.ProductCategories;
using WMS.BusinessLogic.Services.Products;
using WMS.BusinessLogic.Services.Zones;
using WMS.Infrastructure.Common;
using WMS.Infrastructure.EFContext;
using WMS.Infrastructure.Uow;

namespace WMS.BusinessLogicLayer;

public static class ServiceConfigurator
{
    public static IServiceCollection BusinessLogicConfigure(this IServiceCollection services)
    {

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(AppConfig.GetConnectionString()));

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IProductCategoryService, ProductCategoryService>();
        services.AddScoped<IZoneService, ZoneService>();
        services.AddScoped<ILocationService, LocationService>();
        services.AddScoped<IInventoryTransactionTypeService, InventoryTransactionTypeService>();
        services.AddScoped<IInventoryService, InventoryService>();
        services.AddScoped<IInventoryTransactionService, InventroryTransactionService>();

        return services;
    }
}

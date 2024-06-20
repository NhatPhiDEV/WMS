using MediatR;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.Locations.Queries.GetByProductSku;

internal sealed class GetLocationByProductSkuQueryHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<GetLocationByProductSkuQuery, IEnumerable<Location>>
{
    private IGenericRepository<Inventory> InventoryRepository => unitOfWork.GetRepository<Inventory>();
    private IGenericRepository<Product> ProductRepository => unitOfWork.GetRepository<Product>();
    private IGenericRepository<Location> LocationRepository => unitOfWork.GetRepository<Location>();

    public async Task<IEnumerable<Location>> Handle(GetLocationByProductSkuQuery request, CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(request.ProductSku))
        {
            var locations = await LocationRepository.GetMultipleAsync(
                loc => new Location
                {
                    LocationId = loc.LocationId,
                    LocationCode = loc.LocationCode,
                    IsActive = loc.IsActive,
                    ZoneId = loc.ZoneId,
                    Capacity = loc.Capacity,
                    LocationName = loc.LocationName,
                    PointY = loc.PointY,
                    PointX = loc.PointX,
                    PointZ = loc.PointZ,
                    Inventories = loc.Inventories
                }, cancellationToken
            );

            return locations;
        }

        var product = await ProductRepository.GetSingle(
            p => new Product
            {
                ProductId = p.ProductId
            }, p => p.Sku.Equals(request.ProductSku), cancellationToken
        );

        if (product == null) return new List<Location>();

        var inventories = await InventoryRepository.GetMultipleAsync(
            i => new Inventory
            {
                Location = i.Location
            }, i => i.ProductId == product.ProductId,
            cancellationToken, ["Location"]
        );

        return inventories.Select(i => i.Location);
    }
}
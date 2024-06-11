using System.Linq.Expressions;
using MediatR;
using WMS.Domain.Enums;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.Locations.Queries.GetAvailable;

internal sealed class GetAvailableLocationsQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetAvailableLocationsQuery, IEnumerable<Location>>
{
    private IGenericRepository<Location> LocationRepository => unitOfWork.GetRepository<Location>();
    private IGenericRepository<Inventory> InventoryRepository => unitOfWork.GetRepository<Inventory>();

    public async Task<IEnumerable<Location>> Handle(GetAvailableLocationsQuery request, CancellationToken cancellationToken)
    {
        if (request.ProductId == null && request.TransactionType is EInventoryTransactionTypes.None or EInventoryTransactionTypes.Out)
        {
            return [];
        }

        Expression<Func<Location, bool>> predicate = item
            => item.Inventories.Count == 0
               && item.ParentLocationId != null
               && item.Row > 0 && item.Col > 0;

        var locations = await LocationRepository
            .GetMultipleAsync(loc => new Location
            {
                LocationId = loc.LocationId,
                Position = loc.Position,
                Capacity = loc.Capacity,
                Row = loc.Row,
                Col = loc.Col,
                Inventories = loc.Inventories,
                LocationCode = loc.LocationCode,
                LocationName = loc.LocationName
            }, predicate, cancellationToken, ["Inventories"]);


        if (request.ProductId == null) return locations;

        var inventories = await InventoryRepository
            .GetMultipleAsync(inv => new Inventory
            {
                InventoryId = inv.InventoryId,
                Location = inv.Location,
                Quantity = inv.Quantity
            }, inv => inv.ProductId == request.ProductId && inv.IsActive
                , cancellationToken, ["Location", "Location.Inventories"]);

        switch (inventories.Count)
        {
            case > 0 when request.TransactionType == EInventoryTransactionTypes.In:
                {
                    //Location.Capacity : Số lượng quy định của một vị trí
                    //Quantity: Số hàng trong kho
                    //Location.Position: Vị trí trong kho

                    var result = inventories
                        .Where(i => (i.Location.Capacity - i.Quantity) >= request.Quantity)
                        .OrderBy(i => i.Location.Position);

                    return [.. result.Select(i => i.Location), .. locations];
                }
            case > 0 when request.TransactionType == EInventoryTransactionTypes.Out:
                {
                    var result = inventories.Where(i => i.Quantity >= 0).OrderBy(i => i.Location.Position);
                    return [.. result.Select(i => i.Location)];
                }
            case 0 when request.TransactionType == EInventoryTransactionTypes.Out:
                return [];
            default:
                return locations;
        }
    }
}
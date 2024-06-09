using System.Linq.Expressions;
using WMS.Domain.Enums;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.BusinessLogic.Services.Locations;

public class LocationService(IUnitOfWork unitOfWork) : ILocationService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    private IGenericRepository<Location> LocationRepository => _unitOfWork.GetRepository<Location>();
    private IGenericRepository<Inventory> InventoryRepository => _unitOfWork.GetRepository<Inventory>();

    /// <summary>
    /// Lấy vị trí trống gần nhất
    /// </summary>
    /// <returns></returns>
    public List<Location> GetAvailableLocations(
        int? productId,
        int quanlity,
        EInventoryTransactionTypes transactionType)
    {
        if (productId == null && transactionType == EInventoryTransactionTypes.None) { return []; }

        Expression<Func<Location, bool>> expression = item
            => item.Inventories.Count == 0
            && item.ParentLocationId != null
            && item.Row > 0 && item.Col > 0;

        // Không có thì lấy ra vị trí trống gần nhất
        var locations = LocationRepository.FindBy(expression, "Inventories")
            .OrderBy(l => l.Position)
            .ToList();

        if (productId != null)
        {
            var inventories = InventoryRepository.FindBy(item => item.ProductId == productId && item.IsActive, "Location").ToList();
            if (inventories.Count > 0)
            {
                // Nhap
                if (transactionType == EInventoryTransactionTypes.In)
                {
                    //Location.Capacity : Số lượng quy định của một vị trí
                    //Quanlity: Số hàng trong kho
                    //Location.Position: Vị trí trong kho
                    var result = inventories.Where(i => (i.Location.Capacity - i.Quantity) >= quanlity).OrderBy(i => i.Location.Position);
                    return [.. result.Select(i => i.Location), .. locations];
                }
                // Xuat
                if (transactionType == EInventoryTransactionTypes.Out)
                {
                    var result = inventories.Where(i => i.Quantity >= 0).OrderBy(i => i.Location.Position);
                    return [.. result.Select(i => i.Location)];
                }
            }
            if(inventories.Count == 0 && transactionType == EInventoryTransactionTypes.Out)
            {
                return [];
            }
        }
        return locations;
    }

    public List<Location> GetLocationsByLocationCode(string locationCode)
    {
        var rootLocations = LocationRepository.FindBy(l => l.LocationCode.Contains(locationCode), ["InverseParentLocation"]).ToList();
        var allLocations = new HashSet<Location>(rootLocations); // Sử dụng HashSet để loại bỏ trùng lặp
        var locationsToCheck = new Queue<Location>(rootLocations); // Sử dụng Queue để duyệt theo chiều rộng

        while (locationsToCheck.Count > 0)
        {
            var currentLocation = locationsToCheck.Dequeue();

            if (currentLocation.ParentLocationId != null)
            {
                var parentLocation = LocationRepository.FindBy(l => l.LocationId == currentLocation.ParentLocationId, ["InverseParentLocation"]).FirstOrDefault();

                if (parentLocation != null && !allLocations.Any(item => item.LocationId == parentLocation.LocationId))
                {
                    allLocations.Add(parentLocation);
                    locationsToCheck.Enqueue(parentLocation);
                }
            }
        }

        // Giảm dần theo vị trí
        return [.. allLocations.OrderBy(l => l.Position)];
    }

    public List<Location> GetLocationsByZoneId(int zoneId)
    {
        var locations = LocationRepository.FindBy(item => item.ZoneId == zoneId, ["InverseParentLocation"]);

        return [.. locations.OrderBy(l => l.Position)];
    }
}

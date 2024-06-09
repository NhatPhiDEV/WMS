using WMS.Domain.Enums;
using WMS.Domain.Models;

namespace WMS.BusinessLogic.Services.Locations;

public interface ILocationService
{
    List<Location> GetLocationsByZoneId(int zoneId);
    List<Location> GetLocationsByLocationCode(string locationCode);
    List<Location> GetAvailableLocations(int? productId, int quanlity, EInventoryTransactionTypes transactionType);
}

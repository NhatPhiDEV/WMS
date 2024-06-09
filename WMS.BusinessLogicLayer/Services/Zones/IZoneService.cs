using WMS.BusinessLogic.Dtos.Zones;
using WMS.Domain.Models;

namespace WMS.BusinessLogic.Services.Zones;

public interface IZoneService
{
    List<ZoneDto> GetZones();
}

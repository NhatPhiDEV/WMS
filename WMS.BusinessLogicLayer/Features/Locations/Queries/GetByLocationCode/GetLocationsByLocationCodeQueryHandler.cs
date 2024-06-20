using MediatR;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.Locations.Queries.GetByLocationCode;

internal sealed class GetLocationsByLocationCodeQueryHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<GetLocationsByLocationCodeQuery, IEnumerable<Location>>
{

    private IGenericRepository<Location> LocationRepository => unitOfWork.GetRepository<Location>();

    public async Task<IEnumerable<Location>> Handle(
        GetLocationsByLocationCodeQuery request,
        CancellationToken cancellationToken)
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
                Inventories = loc.Inventories,
            }, loc => loc.LocationCode.Contains(request.LocationCode),
            cancellationToken, ["Inventories"]
        );

        return locations;
    }
}
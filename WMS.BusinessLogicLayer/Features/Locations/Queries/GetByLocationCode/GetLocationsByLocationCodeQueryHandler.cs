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
                ParentLocation = loc.ParentLocation,
                ParentLocationId = loc.ParentLocationId,
            }, loc => loc.LocationCode.Contains(request.LocationCode),
            cancellationToken, ["ParentLocation"]
        );

        var locationIds = new HashSet<int>(locations.Select(loc => loc.LocationId));
        var locationsToProcess = new Queue<Location>(locations);

        while (locationsToProcess.Count > 0)
        {
            var currentLocation = locationsToProcess.Dequeue();

            if (!currentLocation.ParentLocationId.HasValue)
                continue;

            var parentLocation = currentLocation.ParentLocation;

            if (parentLocation != null && locationIds.Add(parentLocation.LocationId))
            {
                locationsToProcess.Enqueue(parentLocation);
            }

            // Xử lý cho trường hợp có RẤT nhiều quan hệ cha-con
            if (parentLocation != null || locationIds.Contains(currentLocation.ParentLocationId.Value)) continue;

            var rootLocationId = currentLocation.ParentLocationId.Value;
            var rootLocation = await LocationRepository.GetSingle(
                loc => new Location
                {
                    LocationId = loc.LocationId,
                    ParentLocation = loc.ParentLocation,
                    ParentLocationId = loc.ParentLocationId,
                },
                loc => loc.LocationId == rootLocationId,
                cancellationToken, ["ParentLocation"]
            );

            if (rootLocation == null || !locationIds.Add(rootLocation.LocationId))
                continue;

            locationsToProcess.Enqueue(rootLocation);
        }

        var result = await LocationRepository.GetMultipleAsync(
            loc => new Location
            {
                LocationId = loc.LocationId,
                LocationCode = loc.LocationCode,
                ParentLocation = loc.ParentLocation,
                ParentLocationId = loc.ParentLocationId,
                IsActive = loc.IsActive,
                ZoneId = loc.ZoneId,
                Capacity = loc.Capacity,
                InverseParentLocation = loc.InverseParentLocation,
                LocationName = loc.LocationName,
                Position = loc.Position
            },
            loc => locationIds.Contains(loc.LocationId),
            cancellationToken, ["InverseParentLocation", "ParentLocation"]
        );

        return result;
    }
}
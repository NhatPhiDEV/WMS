using MediatR;
using WMS.Application.DTO;
using WMS.Domain.Models;
using WMS.Domain.Shared.Pagination;
using WMS.Domain.Shared.QueryParams;
using WMS.Domain.Utils;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.Locations.Queries.GetLocations;

internal sealed class GetLocationsQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetLocationsQuery, IPagedList<LocationDto>>
{
    private readonly IGenericRepository<Location> _locationRepository = unitOfWork.GetRepository<Location>();

    public async Task<IPagedList<LocationDto>> Handle(GetLocationsQuery request, CancellationToken cancellationToken)
    {
        var queryOption = new QueryOptions<Location, LocationDto>
        {
            Selector = loc => new LocationDto(
                    loc.LocationId,
                    loc.LocationCode,
                    loc.LocationName,
                    loc.Capacity,
                    loc.Zone.ZoneId,
                    loc.Zone.ZoneName,
                    loc.PointX,
                    loc.PointY,
                    loc.PointZ,
                    loc.IsActive,
                    loc.CreatedAt.ToFormat("dd/MM/yyyy hh:mm:ss"),
                    loc.UpdatedAt.ToFormat("dd/MM/yyyy hh:mm:ss")
                ),

            CancellationToken = cancellationToken,
            Includes = ["Zone"],
            Page = request.Page,
            PageSize = request.PageSize,
            Predicate = p =>
                ((request.SearchTemp == "" ||
                  p.LocationCode.Contains(request.SearchTemp) ||
                  p.LocationName.Contains(request.SearchTemp)) &&
                 p.IsDeleted == false),
            OrderByDescending = true,
            OrderBy = p => p.UpdatedAt
        };

        return await _locationRepository.GetPagedListAsync(queryOption);
    }
}
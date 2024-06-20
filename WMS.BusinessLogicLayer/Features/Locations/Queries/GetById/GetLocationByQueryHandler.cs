﻿using MediatR;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.Locations.Queries.GetById;

internal sealed class GetLocationByQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetLocationByIdQuery, Location?>
{
    private readonly IGenericRepository<Location> LocationRepostory = unitOfWork.GetRepository<Location>();

    public async Task<Location?> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
    {
        return await LocationRepostory.GetSingle(
            loc => new Location
            {
                LocationId = loc.LocationId,
                Capacity = loc.Capacity,
                PointZ = loc.PointZ,
                PointX = loc.PointX,
                PointY = loc.PointY,
                Inventories = loc.Inventories,
                LocationCode = loc.LocationCode,
                LocationName = loc.LocationName
            }, loc => loc.LocationId == request.LocationId
        );
    }
}
﻿using MediatR;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.Zones.Queries.GetMultiple
{
    internal sealed class GetMultipleZoneQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetMultipleZoneQuery, List<Zone>>
    {
        private IGenericRepository<Zone> ZoneRepository => unitOfWork.GetRepository<Zone>();

        public async Task<List<Zone>> Handle(GetMultipleZoneQuery request, CancellationToken cancellationToken)
        {
            var result = await ZoneRepository
                .GetMultipleAsync(
                    z => new Zone
                    {
                        ZoneId = z.ZoneId,
                        ZoneName = z.ZoneName
                    },
                    z => z.IsActive == true,
                    cancellationToken, []);

            return result;
        }
    }
}
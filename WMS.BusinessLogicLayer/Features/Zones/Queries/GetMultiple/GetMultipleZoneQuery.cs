using MediatR;
using WMS.Domain.Models;

namespace WMS.Application.Features.Zones.Queries.GetMultiple;

public record GetMultipleZoneQuery : IRequest<IEnumerable<Zone>>;
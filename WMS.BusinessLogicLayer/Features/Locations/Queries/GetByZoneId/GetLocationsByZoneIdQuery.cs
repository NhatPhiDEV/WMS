using MediatR;
using WMS.Domain.Models;

namespace WMS.Application.Features.Locations.Queries.GetByZoneId;

public record GetLocationsByZoneIdQuery(int ZoneId) : IRequest<IEnumerable<Location>>;

using MediatR;
using WMS.Domain.Models;

namespace WMS.Application.Features.Locations.Queries.GetByLocationCode;

public record GetLocationsByLocationCodeQuery(string LocationCode) : IRequest<IEnumerable<Location>>;
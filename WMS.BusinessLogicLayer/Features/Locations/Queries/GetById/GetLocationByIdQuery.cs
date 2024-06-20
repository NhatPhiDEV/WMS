using MediatR;
using WMS.Domain.Models;

namespace WMS.Application.Features.Locations.Queries.GetById;

public record GetLocationByIdQuery(int LocationId) : IRequest<Location?>;
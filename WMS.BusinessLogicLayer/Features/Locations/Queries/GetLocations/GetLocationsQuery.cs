using MediatR;
using WMS.Application.DTO;
using WMS.Domain.Models;
using WMS.Domain.Shared.Pagination;

namespace WMS.Application.Features.Locations.Queries.GetLocations;

public record GetLocationsQuery(string SearchTemp, int Page, int PageSize) : IRequest<IPagedList<LocationDto>>;
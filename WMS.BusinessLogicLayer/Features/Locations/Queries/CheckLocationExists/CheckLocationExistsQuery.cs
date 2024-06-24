using MediatR;

namespace WMS.Application.Features.Locations.Queries.CheckLocationExists;

public record CheckLocationExistsQuery(
    int LocationId, 
    string PointX,
    string PointY,
    string PointZ): IRequest<bool>;
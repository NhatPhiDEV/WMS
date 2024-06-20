using MediatR;
using WMS.Domain.Models;

namespace WMS.Application.Features.Locations.Queries.GetByProductSku
{
    public record GetLocationByProductSkuQuery(string ProductSku) : IRequest<IEnumerable<Location>>;
}

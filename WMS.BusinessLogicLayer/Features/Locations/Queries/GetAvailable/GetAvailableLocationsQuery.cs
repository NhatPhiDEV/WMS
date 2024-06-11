using MediatR;
using WMS.Domain.Enums;
using WMS.Domain.Models;

namespace WMS.Application.Features.Locations.Queries.GetAvailable;

public record GetAvailableLocationsQuery(int? ProductId, int Quantity, EInventoryTransactionTypes TransactionType) 
    : IRequest<IEnumerable<Location>>;
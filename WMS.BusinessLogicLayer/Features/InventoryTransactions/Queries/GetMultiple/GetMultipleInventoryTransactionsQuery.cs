using MediatR;
using WMS.Domain.Models;

namespace WMS.Application.Features.InventoryTransactions.Queries.GetMultiple
{
    public record GetMultipleInventoryTransactionsQuery(string Search)
        : IRequest<IEnumerable<InventoryTransaction>>;
}
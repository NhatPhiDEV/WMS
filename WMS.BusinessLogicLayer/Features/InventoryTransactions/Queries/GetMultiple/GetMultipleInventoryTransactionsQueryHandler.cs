using MediatR;
using System.Linq.Expressions;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.InventoryTransactions.Queries.GetMultiple;

internal sealed class GetMultipleInventoryTransactionsQueryHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<GetMultipleInventoryTransactionsQuery, IEnumerable<InventoryTransaction>>
{
    private IGenericRepository<InventoryTransaction> Repository
        => unitOfWork.GetRepository<InventoryTransaction>();

    public async Task<IEnumerable<InventoryTransaction>> Handle(
        GetMultipleInventoryTransactionsQuery request,
        CancellationToken cancellationToken)
    {
        Expression<Func<InventoryTransaction, bool>> predicate = i
            => request.Search == "" // Default
               || i.Product.Sku.Contains(request.Search)
               || i.Location.LocationCode.Contains(request.Search);

        var result = await Repository.GetMultipleAsync(
            i => new InventoryTransaction
            {
                TransactionId = i.TransactionId,
                Product = i.Product,
                Location = i.Location,
                InventoryTransactionType = i.InventoryTransactionType,
                Quantity = i.Quantity,
                Status = i.Status,
                TransactionDate = i.TransactionDate,
                Notes = i.Notes
            },
            predicate,
            cancellationToken,
            ["Product", "InventoryTransactionType", "Location"]
        );

        return result.OrderByDescending(i => i.TransactionDate);
    }
}
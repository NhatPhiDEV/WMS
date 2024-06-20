using MediatR;
using WMS.Domain.Models;
using WMS.Domain.Utils;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.InventoryTransactions.Commands.Create;

internal class CreateInventoryTransactionCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<CreateInventoryTransactionCommand>
{
    private IGenericRepository<InventoryTransaction> Repository => unitOfWork.GetRepository<InventoryTransaction>();

    public async Task Handle(
        CreateInventoryTransactionCommand request,
        CancellationToken cancellationToken)
    {
        var entity = new InventoryTransaction
        {
            LocationId = request.LocationId,
            ProductId = request.ProductId,
            Quantity = request.Quantity,
            InventoryTransactionTypeId = request.InventoryTransactionTypeId,
            TransactionDate = TimeHelper.GetCurrentTime(),
            ReferenceId = 0, // Chua dung
            Notes = request.Reason,
            Status = request.Status, 
        };

        Repository.Create(entity);

        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
using MediatR;
using WMS.Domain.Enums;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.Inventories.Commands.Upsert
{
    internal sealed class UpsertInventoryCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<UpsertInventoryCommand>
    {
        private IGenericRepository<Inventory> InventoryRepository => unitOfWork.GetRepository<Inventory>();

        public async Task Handle(UpsertInventoryCommand request, CancellationToken cancellationToken)
        {
            var localItem = await InventoryRepository.GetSingle(item =>
                item.ProductId == request.Inventory.ProductId
                && item.LocationId == request.Inventory.LocationId
                && item.IsActive, cancellationToken);

            if (localItem == null)
            {
                InventoryRepository.Create(request.Inventory);
                await unitOfWork.SaveChangesAsync(cancellationToken);
            }
            else
            {
                switch (request.TransactionType)
                {
                    case EInventoryTransactionTypes.In:
                        // Tăng số lượng hàng
                        request.Inventory.Quantity += localItem.Quantity;
                        request.Inventory.InventoryId = localItem.InventoryId;

                        InventoryRepository.Update(request.Inventory);
                        await unitOfWork.SaveChangesAsync(cancellationToken);
                        break;
                    case EInventoryTransactionTypes.Out:
                        {
                            // Giảm số lượng hàng
                            request.Inventory.Quantity = localItem.Quantity - request.Inventory.Quantity;
                            request.Inventory.InventoryId = localItem.InventoryId;

                            // Nếu xuất hết hàng thì sẽ xóa dòng đã lưu đi
                            if (request.Inventory.Quantity == 0)
                            {
                                request.Inventory.IsActive = false;
                            }

                            InventoryRepository.Update(request.Inventory);
                            await unitOfWork.SaveChangesAsync(cancellationToken);
                            break;
                        }
                    case EInventoryTransactionTypes.None:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(request.TransactionType), request.TransactionType, null);
                }
            }
        }
    }
}

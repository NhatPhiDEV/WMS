using WMS.Domain.Enums;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.BusinessLogic.Services.Inventories;

public class InventoryService(IUnitOfWork unitOfWork) : IInventoryService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    private IGenericRepository<Inventory> InventoryRepository => _unitOfWork.GetRepository<Inventory>();

    public void InsertOrUpdateInventory(Inventory inventory, EInventoryTransactionTypes transactionType)
    {
        var localItem = InventoryRepository.FindBy(item 
            => item.ProductId == inventory.ProductId
            && item.LocationId == inventory.LocationId
            && item.IsActive).FirstOrDefault();

        if(localItem == null)
        {
            InventoryRepository.Create(inventory);
            _unitOfWork.Commit();
        }
        else
        {
            if(transactionType == EInventoryTransactionTypes.In)
            {
                // Tăng số lượng hàng
                inventory.Quantity += localItem.Quantity;
                inventory.InventoryId = localItem.InventoryId;

                InventoryRepository.Update(inventory);
                _unitOfWork.Commit();

            }
            if (transactionType == EInventoryTransactionTypes.Out)
            {
                // Giảm số lượng hàng
                inventory.Quantity -= localItem.Quantity;
                inventory.InventoryId = localItem.InventoryId;

                // Nếu xuất hết hàng thì sẽ xóa dòng đã lưu đi
                if(inventory.Quantity == 0)
                {
                    inventory.IsActive = false;
                }

                InventoryRepository.Update(inventory);
                _unitOfWork.Commit();

            }
        }
    }
}

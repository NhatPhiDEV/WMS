using WMS.Domain.Enums;
using WMS.Domain.Models;

namespace WMS.BusinessLogic.Services.Inventories;

public interface IInventoryService
{
    void InsertOrUpdateInventory(Inventory inventory, EInventoryTransactionTypes transactionType);
}

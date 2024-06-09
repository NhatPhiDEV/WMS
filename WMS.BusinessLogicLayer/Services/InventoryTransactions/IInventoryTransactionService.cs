using WMS.BusinessLogic.Dtos.InventoryTransactions;
using WMS.Domain.Models;

namespace WMS.BusinessLogic.Services.InventoryTransactions;

public interface IInventoryTransactionService
{
    void CreateInventoryTransaction(InventoryTransaction transaction);
    /// <summary>
    /// Load danh sách transaction mới nhất
    /// </summary>
    List<InventoryTransactionDto> GetTransaction(string? search);
}

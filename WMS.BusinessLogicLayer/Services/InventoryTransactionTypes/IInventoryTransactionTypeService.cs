using WMS.BusinessLogic.Dtos.Base;

namespace WMS.BusinessLogic.Services.InventoryTransactionTypes;

public interface IInventoryTransactionTypeService
{
    /// <summary>
    /// Combobox Lệnh
    /// </summary>
    /// <returns></returns>
    List<SelectorDto> GetOptions();
}

using System.Linq.Expressions;
using WMS.BusinessLogic.Dtos.Base;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.BusinessLogic.Services.InventoryTransactionTypes;

public class InventoryTransactionTypeService(IUnitOfWork unitOfWork) : IInventoryTransactionTypeService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    private IGenericRepository<InventoryTransactionType> InventoryTransactionTypeRepository => _unitOfWork.GetRepository<InventoryTransactionType>();

    public List<SelectorDto> GetOptions()
    {
        Expression<Func<InventoryTransactionType, SelectorDto>> selector = i
            => new SelectorDto
            {
                Key = i.InventoryTransactionTypeId,
                Value = i.InventoryTransactionTypeName
            };

        var result = InventoryTransactionTypeRepository
            .FindBy(selector, null, null).ToList();

        return result;
    }
}

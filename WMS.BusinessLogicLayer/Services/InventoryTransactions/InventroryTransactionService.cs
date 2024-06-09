using System.Linq.Expressions;
using WMS.BusinessLogic.Dtos.InventoryTransactions;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.BusinessLogic.Services.InventoryTransactions;

public class InventroryTransactionService(IUnitOfWork unitOfWork) : IInventoryTransactionService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    private IGenericRepository<InventoryTransaction> InventoryTransactionRepository => _unitOfWork.GetRepository<InventoryTransaction>();

    public void CreateInventoryTransaction(InventoryTransaction transaction)
    {
         InventoryTransactionRepository.Create(transaction);
         _unitOfWork.Commit();
    }

    public List<InventoryTransactionDto> GetTransaction(string? search = null)
    {
        Expression<Func<InventoryTransaction, InventoryTransactionDto>> selector = i => new InventoryTransactionDto
        {
            TransactionId = i.TransactionId,
            InventoryTransactionType = i.InventoryTransactionType.InventoryTransactionTypeName,
            Location = i.Location.LocationCode,
            Notes = i.Notes,
            ProductSku = i.Product.Sku,
            Quanlity = i.Quantity.ToString(),
            TransactionDate = i.TransactionDate.ToString("dd/MM/yyyy HH:mm:ss"),
            Status = i.Status.ToString()
        };

        Expression<Func<InventoryTransaction, bool>> predicate = i
            => search == null || i.Product.Sku.Contains(search) || i.Location.LocationCode.Contains(search);

        var result = InventoryTransactionRepository
            .FindBy(selector, predicate, ["Product", "InventoryTransactionType", "Location"])
            .OrderByDescending(i => i.TransactionId)
            .ToList();

        return result;
    }
}

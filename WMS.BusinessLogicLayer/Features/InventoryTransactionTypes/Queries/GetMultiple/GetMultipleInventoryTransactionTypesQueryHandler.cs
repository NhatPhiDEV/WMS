using MediatR;
using WMS.Application.Common;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.InventoryTransactionTypes.Queries.GetMultiple
{
    internal sealed class GetMultipleInventoryTransactionTypesQueryHandler(IUnitOfWork unitOfWork)
        : IRequestHandler<GetMultipleInventoryTransactionTypesQuery, IEnumerable<ComboBoxItem>>
    {
        private IGenericRepository<InventoryTransactionType> Repository
            => unitOfWork.GetRepository<InventoryTransactionType>();

        public async Task<IEnumerable<ComboBoxItem>> Handle(
            GetMultipleInventoryTransactionTypesQuery request,
            CancellationToken cancellationToken)
        {

            var result = await Repository
                .GetMultipleAsync(
                    z => new ComboBoxItem
                    {
                        Key = z.InventoryTransactionTypeId,
                        Val = z.InventoryTransactionTypeName
                    }, cancellationToken);

            return result;
        }
    }
}
using MediatR;
using WMS.Application.Common;

namespace WMS.Application.Features.InventoryTransactionTypes.Queries.GetMultiple
{
    public record GetMultipleInventoryTransactionTypesQuery : IRequest<IEnumerable<ComboBoxItem>>;
}
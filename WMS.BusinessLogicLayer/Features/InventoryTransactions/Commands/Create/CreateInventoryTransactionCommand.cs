using MediatR;
using WMS.Domain.Enums;

namespace WMS.Application.Features.InventoryTransactions.Commands.Create;

public record CreateInventoryTransactionCommand
(
    int LocationId,
    int ProductId,
    int Quantity,
    int InventoryTransactionTypeId,
    EInventoryTransactionStatus Status,
    string Reason
) : IRequest;
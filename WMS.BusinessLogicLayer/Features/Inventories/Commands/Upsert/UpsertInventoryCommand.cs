using MediatR;
using WMS.Domain.Enums;
using WMS.Domain.Models;

namespace WMS.Application.Features.Inventories.Commands.Upsert;

public record UpsertInventoryCommand(Inventory Inventory, EInventoryTransactionTypes TransactionType) : IRequest;
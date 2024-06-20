using MediatR;
using WMS.Domain.Models;

namespace WMS.Application.Features.Products.Queries.GetBySku;

public record GetProductIdBySkuQuery(string? Sku) : IRequest<Product?>;
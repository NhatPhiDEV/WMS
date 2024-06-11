using MediatR;

namespace WMS.Application.Features.Products.Commands.Create;

public record CreateProductCommand(string Sku, string ProductName, int ProductCategoryId) : IRequest;
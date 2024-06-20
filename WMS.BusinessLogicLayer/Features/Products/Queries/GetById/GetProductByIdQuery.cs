using MediatR;
using WMS.Domain.Models;

namespace WMS.Application.Features.Products.Queries.GetById;

public record GetProductByIdQuery(int ProductId) : IRequest<Product?>;
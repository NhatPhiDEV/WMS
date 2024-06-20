using MediatR;

namespace WMS.Application.Features.Products.Commands.Delete;

public record DeleteProductCommand(int ProductId) : IRequest;
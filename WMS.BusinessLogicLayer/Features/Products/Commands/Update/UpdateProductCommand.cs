using MediatR;
using WMS.Domain.Models;

namespace WMS.Application.Features.Products.Commands.Update;

public record UpdateProductCommand(Product Product) : IRequest; 
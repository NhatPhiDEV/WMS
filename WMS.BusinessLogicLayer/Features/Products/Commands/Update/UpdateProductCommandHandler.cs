using MediatR;
using WMS.Domain.Models;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.Products.Commands.Update;

internal sealed class UpdateProductCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<UpdateProductCommand>
{
    public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var productRepository = unitOfWork.GetRepository<Product>();

        productRepository.Update(request.Product);

        await unitOfWork.SaveChangesAsync(cancellationToken);

    }
}
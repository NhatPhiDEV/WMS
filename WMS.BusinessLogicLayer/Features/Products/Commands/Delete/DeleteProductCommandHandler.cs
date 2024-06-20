using MediatR;
using WMS.Domain.Models;
using WMS.Domain.Utils;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.Products.Commands.Delete;

internal sealed class DeleteProductCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<DeleteProductCommand>
{
    public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        await unitOfWork.BeginTransaction();

        var productRepository = unitOfWork.GetRepository<Product>();

        var product = await productRepository.FindByIdAsync(request.ProductId, cancellationToken);

        if (product == null) { return; }

        product.UpdatedAt = TimeHelper.GetCurrentTime();
        product.IsDeleted = true;

        productRepository.Update(product);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        await unitOfWork.CommitTransaction();
    }
}
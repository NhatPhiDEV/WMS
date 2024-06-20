using MediatR;
using WMS.Domain.Models;
using WMS.Domain.Utils;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.Products.Commands.Create;

internal sealed class CreateProductCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand>
{
    private IGenericRepository<Product> ProductRepository => unitOfWork.GetRepository<Product>();

    public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Sku = request.Sku,
            ProductName = request.ProductName,
            ProductCategoryId = request.ProductCategoryId,
            IsActive = true,
            ImagePath = "",
            CreatedAt = TimeHelper.GetCurrentTime(),
            UpdatedAt = TimeHelper.GetCurrentTime(),
            ExpirationDate = request.NumExpirationDate,
            IsDeleted = false
        };

        ProductRepository.Create(product);

        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
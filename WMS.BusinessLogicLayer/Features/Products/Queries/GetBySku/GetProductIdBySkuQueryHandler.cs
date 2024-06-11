using MediatR;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.Products.Queries.GetBySku;

internal sealed class GetProductIdBySkuQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetProductIdBySkuQuery, Product?>
{
    private IGenericRepository<Product> ProductRepository => unitOfWork.GetRepository<Product>();

    public async Task<Product?> Handle(
        GetProductIdBySkuQuery request,
        CancellationToken cancellationToken)
    {
        var result = await ProductRepository.GetSingle(
            p => new Product
            {
                ProductId = p.ProductId
            },
            p => p.Sku.Equals(request.Sku) && p.IsActive,
            cancellationToken);

        return result;
    }
}
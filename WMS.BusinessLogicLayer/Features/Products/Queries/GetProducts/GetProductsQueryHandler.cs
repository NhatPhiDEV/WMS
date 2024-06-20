using MediatR;
using WMS.Domain.Models;
using WMS.Domain.Shared.Pagination;
using WMS.Domain.Shared.QueryParams;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.Products.Queries.GetProducts;

internal sealed class GetProductsQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetProductsQuery, IPagedList<Product>>
{
    private readonly IGenericRepository<Product> _productRepository = unitOfWork.GetRepository<Product>();
    public async Task<IPagedList<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        var queryOption = new QueryOptions<Product, Product>
        {
            Selector = p => new Product
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                Sku = p.Sku,
                IsActive = p.IsActive,
                ProductCategoryId = p.ProductCategoryId,
                ImagePath = p.ImagePath,
                ProductCategory = p.ProductCategory,
                ExpirationDate = p.ExpirationDate,
                CreatedAt = p.CreatedAt,
                UpdatedAt = p.UpdatedAt,
                IsDeleted = p.IsDeleted
            },
            CancellationToken = cancellationToken,
            Includes = ["ProductCategory"],
            Page = request.Page,
            PageSize = request.PageSize,
            Predicate = p =>
                ((request.SearchTemp == "" ||
                  p.Sku.Contains(request.SearchTemp) ||
                  p.ProductName.Contains(request.SearchTemp)) &&
                 p.IsDeleted == false),
            OrderByDescending = true,
            OrderBy = p => p.UpdatedAt
        };

        return await _productRepository.GetPagedListAsync(queryOption);
    }
}
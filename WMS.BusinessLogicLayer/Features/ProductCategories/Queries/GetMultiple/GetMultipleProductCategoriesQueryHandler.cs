using MediatR;
using WMS.Application.Common;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.ProductCategories.Queries.GetMultiple;

internal sealed class GetMultipleProductCategoriesQueryHandler(IUnitOfWork unitOfWork) :
    IRequestHandler<GetMultipleProductCategoriesQuery, IEnumerable<ComboBoxItem>>
{
    private IGenericRepository<ProductCategory> ProductCategoryRepository => unitOfWork.GetRepository<ProductCategory>();

    public async Task<IEnumerable<ComboBoxItem>> Handle(
        GetMultipleProductCategoriesQuery request,
        CancellationToken cancellationToken)
    {
        var result = await ProductCategoryRepository
            .GetMultipleAsync(
                z => new ComboBoxItem
                {
                    Key = z.ProductCategoryId,
                    Val = z.ProductCategoryName
                }, cancellationToken);

        return result;
    }
}
using WMS.BusinessLogic.Dtos.Base;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.BusinessLogic.Services.ProductCategories
{
    public class ProductCategoryService(IUnitOfWork unitOfWork) : IProductCategoryService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        private IGenericRepository<ProductCategory> ProductCategoryRepository => _unitOfWork.GetRepository<ProductCategory>();
        
        public List<SelectorDto> GetOptions()
        {
            var result = ProductCategoryRepository.FindBy(
                    item => new SelectorDto
                    {
                        Key = item.ProductCategoryId,
                        Value = item.ProductCategoryName
                    }, null, null);

            return [.. result];
        }
    }
}

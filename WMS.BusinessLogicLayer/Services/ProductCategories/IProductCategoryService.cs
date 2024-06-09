using WMS.BusinessLogic.Dtos.Base;
namespace WMS.BusinessLogic.Services.ProductCategories
{
    public interface IProductCategoryService
    {
        List<SelectorDto> GetOptions();
    }
}

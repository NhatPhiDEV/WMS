using WMS.Domain.Models;

namespace WMS.BusinessLogic.Services.Products
{
    public interface IProductService
    {
        Product? GetProductBySku(string sku);

        void CreateProduct(Product product);
    }
}

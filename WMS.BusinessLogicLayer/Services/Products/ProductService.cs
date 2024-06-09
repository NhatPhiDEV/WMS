using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.BusinessLogic.Services.Products
{
    public class ProductService(IUnitOfWork unitOfWork) : IProductService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        private IGenericRepository<Product> ProductRepository => _unitOfWork.GetRepository<Product>();

        public void CreateProduct(Product product)
        {
            ProductRepository.Create(product);
        }

        public Product? GetProductBySku(string sku)
        {
            return ProductRepository.FindBy(p => p.Sku == sku && p.IsActive).FirstOrDefault();
        }

    }
}

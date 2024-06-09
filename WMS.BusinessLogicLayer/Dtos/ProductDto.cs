using Models = WMS.Domain.Models;
namespace WMS.BusinessLogic.Dtos
{
    public class ProductDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = null!;

        public string ImagePath { get; set; } = string.Empty;

        public string Sku { get; set; } = null!;

        public DateTime ExpiryDate { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Models.Attribute> Attributes { get; set; } = [];
        public virtual Models.ProductCategory ProductCategory { get; set; } = null!;

    }
}

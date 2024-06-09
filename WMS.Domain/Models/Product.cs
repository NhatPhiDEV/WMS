using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WMS.Domain.Models;

[Table(name: "Products")]
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductId { get; set; }

    /// <summary>
    /// Tên sản phẩm
    /// </summary>
    [MaxLength(50)]
    [Column(TypeName = "nvarchar(50)")]
    public string ProductName { get; set; } = null!;

    /// <summary>
    /// Đường dẫn ảnh
    /// </summary>
    [MaxLength(255)]
    [Column(TypeName = "nvarchar(255)")]
    public string ImagePath { get; set; } = string.Empty;

    /// <summary>
    /// Mã sản phẩm
    /// </summary>
    [MaxLength(50)]
    [Column(TypeName = "nvarchar(50)")]
    public string Sku { get; set; } = null!;

    /// <summary>
    /// Hạn sử dụng (Ngày)
    /// </summary>
    public int ExpirationDate { get; set; }

    /// <summary>
    /// Trạng thái
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Loại sản phẩm (khóa ngoại)
    /// </summary>
    [ForeignKey(nameof(ProductCategoryId))]
    public int ProductCategoryId { get; set; }

    public virtual ICollection<Models.Attribute> Attributes { get; set; } = [];
    public virtual Models.ProductCategory ProductCategory { get; set; } = null!;

}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WMS.Domain.Models;

[Table(name: "ProductCategories")]
public class ProductCategory
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductCategoryId { get; set; }

    [MaxLength(50)]
    [Column(TypeName = "nvarchar(50)")]
    public string ProductCategoryName { get; set; } = null!;
}

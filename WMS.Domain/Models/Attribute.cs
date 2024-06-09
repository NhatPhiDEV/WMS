using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WMS.Domain.Models;

[Table(name: "Attributes")]
public class Attribute
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AttributeId { get; set; }

    [MaxLength(50)]
    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string AttributeName { get; set; } = null!;

    [MaxLength(50)]
    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string AttributeValue { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<Product> Products { get; set; } = [];

}

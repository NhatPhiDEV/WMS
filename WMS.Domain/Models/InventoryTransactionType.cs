using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WMS.Domain.Models;

[Table(name: "InventoryTransactionTypes")]
public class InventoryTransactionType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int InventoryTransactionTypeId { get; set; }

    [MaxLength(50)]
    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string InventoryTransactionTypeCode { get; set; } = null!;

    [MaxLength(50)]
    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string InventoryTransactionTypeName { get; set; } = null!;

    public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; } = [];
}

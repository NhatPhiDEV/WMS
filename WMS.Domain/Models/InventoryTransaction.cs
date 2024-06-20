using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WMS.Domain.Enums;

namespace WMS.Domain.Models;

[Table(name: "InventoryTransactions")]
public partial class InventoryTransaction
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TransactionId { get; set; }

    [ForeignKey(nameof(ProductId))]
    public int ProductId { get; set; }

    [ForeignKey(nameof(LocationId))]
    public int LocationId { get; set; }

    [ForeignKey(nameof(InventoryTransactionTypeId))]
    public int InventoryTransactionTypeId { get; set; }

    public DateTime TransactionDate { get; set; }

    public int Quantity { get; set; }

    public int ReferenceId { get; set; }

    public string Notes { get; set; } = string.Empty;

    [Column(TypeName = "int")]
    public EInventoryTransactionStatus Status { get; set; }

    public virtual InventoryTransactionType InventoryTransactionType { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;


}

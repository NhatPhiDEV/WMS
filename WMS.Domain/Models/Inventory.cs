using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMS.Domain.Models;

[Table(name: "Inventories")]
public class Inventory
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int InventoryId { get; set; }

    [ForeignKey(nameof(ProductId))]
    public int ProductId { get; set; }

    [ForeignKey(nameof(LocationId))]
    public int LocationId { get; set; }

    public int Quantity { get; set; }

    public DateTime StorageDate { get; set; }

    public bool IsActive { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}

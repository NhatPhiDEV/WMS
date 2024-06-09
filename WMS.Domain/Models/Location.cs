using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WMS.Domain.Models;

[Table(name: "Locations")]
public class Location
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LocationId { get; set; }

    [MaxLength(50)]
    [Column(TypeName = "nvarchar(50)")]
    public string LocationCode { get; set; } = null!;

    [MaxLength(50)]
    [Column(TypeName = "nvarchar(50)")]
    public string LocationName { get; set; } = null!;

    public int ZoneId { get; set; }

    public int Capacity { get; set; }

    public bool IsActive { get; set; }

    public int? ParentLocationId { get; set; }
    /// <summary>
    /// Cột
    /// </summary>
    public int Col { get; set; }
    /// <summary>
    /// Hàng
    /// </summary>
    public int Row { get; set; }
    /// <summary>
    /// Vị trí xuất (vd: dãy A, Dãy B...)
    /// </summary>
    public string Position { get; set; } = string.Empty;

    public virtual ICollection<Inventory> Inventories { get; set; } = [];

    public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; } = [];

    public virtual ICollection<Location> InverseParentLocation { get; set; } = [];

    public virtual Location? ParentLocation { get; set; }

    public virtual Zone? Zone { get; set; }
}

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

    public string PointX { get; set; } = null!;

    public string PointY { get; set; } = null!;

    public string PointZ { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = [];
    public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; } = [];

    public virtual Zone Zone { get; set; } = null!;
}

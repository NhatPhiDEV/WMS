using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WMS.Domain.Models;

[Table(name: "Zones")]
public class Zone
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ZoneId { get; set; }

    [MaxLength(50)]
    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string ZoneName { get; set; } = null!;

    [MaxLength(255)]
    [Column(TypeName = "nvarchar(255)")]
    [Required]
    public string ZoneDescription { get; set; } = string.Empty;

    public bool IsActive { get; set; }

    public virtual ICollection<Location> Locations { get; set; } = [];
}

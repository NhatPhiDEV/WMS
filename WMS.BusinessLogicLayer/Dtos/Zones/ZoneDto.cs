using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.BusinessLogic.Dtos.Zones
{
    public class ZoneDto
    {
        public int ZoneId { get; set; }
        public string ZoneName { get; set; } = null!;
    }
}

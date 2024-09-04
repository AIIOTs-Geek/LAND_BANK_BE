using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public class LandCoordinateVm
    {
        public int MapId { get; set; }
        [Column(TypeName = "decimal(9, 6)")]
        public decimal? Latitude { get; set; }
        [Column(TypeName = "decimal(9, 6)")]
        public decimal? Longitude { get; set; }
        public List<LandShape> LandShapeArray { get; set; }
    }
    public class LandShape
    {
        [Column(TypeName = "decimal(9, 6)")]
        public double Latitude { get; set; }
        [Column(TypeName = "decimal(9, 6)")]
        public double Longitude { get; set; }
    }
}

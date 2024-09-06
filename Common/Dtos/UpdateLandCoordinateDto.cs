using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class UpdateLandCoordinateDto
    {
        public int LandId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string LandShape { get; set; }
    }
}

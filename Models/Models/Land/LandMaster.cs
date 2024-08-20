using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Land
{
    public class LandMaster
    {
        public int Id { get; set; }
        public string LandInformation { get; set; }
        public int DistrictId { get; set; }
        public decimal Area { get; set; }
        public int SubAssetId { get; set; }
        public string Location { get; set; }
        public int LandUseId { get; set; }
        public string BusinessPlanDetailed { get; set; }
        public int LandStatusId { get; set; }
        public int LandTypeId { get; set; }
    }
}

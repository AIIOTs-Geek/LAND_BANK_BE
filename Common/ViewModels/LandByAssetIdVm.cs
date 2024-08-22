using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public class LandByAssetIdVm
    {
        public int LandId { get; set; }
        public string AssetName { get; set; }
        public string SubAssetName { get; set; }
        public string LandUse {  get; set; }
        public string LandType { get; set; }
        public string LandStatus { get; set; }
        public bool WLTStatus { get; set; }
        public decimal LandArea { get; set; }
        public string Location { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
    }
}

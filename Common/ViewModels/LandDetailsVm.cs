using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public class LandDetailsVm
    {
        public int Id { get; set; }
        public string LandInformation { get; set; }
        public string Location { get; set; }
        public decimal Area { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string LandStatus { get; set; }
        public string LandType { get; set; }
        public string LandUse { get; set; }
        public string BusinessPlan { get; set; }
        public string AssetCode { get; set; }
        public string AssetName { get; set; }
        public string SubAssetCode { get; set; }
        public string SubAssetName { get; set; }
    }
}

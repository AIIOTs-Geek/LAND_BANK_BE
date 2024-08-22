using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public class AssetVm
    {
        public int AssetId { get; set; }
        public string AssetName { get; set; }
        public string SubAssetName { get; set; }
        public int? LandCount { get; set; }
        public decimal? TotalArea { get; set; }
    }
}

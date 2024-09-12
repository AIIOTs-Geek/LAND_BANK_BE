using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public class LandByAssetIdVm
    {
        public long LandId { get; set; }
        public string ReferenceNumber { get; set; }
        public string AssetName { get; set; }
        public string SubAssetName { get; set; }
        public string LandUse { get; set; }
        public string LandType { get; set; }
        public decimal? Valuation {  get; set; }
        public string LandStatus { get; set; }
        public string WLTStatus { get; set; }
        public decimal LandArea { get; set; }
        public string Location { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string DeedType { get; set; }
        public string DeedOwner { get; set; }
        public string DeedStatus { get; set; }
        public string BusinessPlan { get; set; }
        public int? Status { get; set; }


        public string StatusName
        {
            get
            {
                return Status switch
                {                    
                    null => "Data Not Submitted",
                    1 => "Approved",
                    2 => "Send Back",
                    3 => "Waiting for Approval",
                   
                };
            }

        }
    }
}

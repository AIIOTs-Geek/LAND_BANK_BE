using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public class LandDetailsVm
    {
        public long LandId { get; set; }
        public string ReferenceId { get; set; }
        public string MapUrl { get; set; }
        public string LandInformation { get; set; }
        public string Location { get; set; }
        public decimal Area { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string LandStatus { get; set; }
        public string LandType { get; set; }
        public string LandUse { get; set; }
        public string BusinessPlan { get; set; }
        public string BusinessPlanDetail { get; set; }
        public string BusinessPlanStatus { get; set; }
        public string AssetCode { get; set; }
        public string AssetName { get; set; }
        public string SubAssetCode { get; set; }
        public string SubAssetName { get; set; }
        public string IsWlt { get; set; }
        public string Masterplan { get; set; }
        public string InfraApproval { get; set; }
        public string InfraContraction { get; set; }
        public string MunHandingOver { get; set; }
        public TitleDeed TitleDeed { get; set; }
        public List<TitleDeed>? OwnerShipDetails { get; set; }
        public SaleDetailsVm? SaleDetails { get; set; }
        public FinanceVm? FinanceDetails { get; set; }
    }
}

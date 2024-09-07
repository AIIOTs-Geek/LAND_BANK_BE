using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class UpdateLandDto
    {
        public string? ActionName { get; set; }
        public int? LandId { get; set; }
        public int? SubAssetId { get; set; }
        public int? DistrictId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Area { get; set; }
        public int? BusinessPlanId { get; set; }
        public int? BusinessPlanStatusId { get; set; }
        public int? BusinessPlanDetailedId { get; set; }
        public int? LandStatusId { get; set; }
        public int? LandUseId { get; set; }
        public int? LandTypeId { get; set; }
        public int? WltStatus { get; set; }
        public int? PlotNumber { get; set; }
        public string? LandInfo { get; set; }  
        public string? Location { get; set; }
        public string? MapUrl { get; set; }
        public int? MasterPlan { get; set; }
        public int? InfraApproval { get; set; }
        public int? InfraContraction { get; set; }
        public int? MunHandingOver { get; set; }
        public int? TitleDeedId { get; set; }
        public int? DeedStatus { get; set; }
        public string? DeedNumber { get; set; }
        public string? DeedDate { get; set; }
        public int? DeedOwner { get; set; }
        public int? DeedType { get; set; }
        public string? DeedUrl { get; set; }
        public int? DeedSequence { get; set; }
    }
}

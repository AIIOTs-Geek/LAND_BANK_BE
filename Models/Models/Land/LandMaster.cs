using Models.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Land
{
    public class LandMaster:BaseModel
    {
        public int ID { get; set; }
        public string LandInformation { get; set; }
        public int districtId { get; set; }
        public decimal Area { get; set; }
        public int SubAssetID { get; set; }
        public string Location { get; set; }
        public string MapImageURL { get; set; }
        public int LandUseId { get; set; }
        public int BussinessPlanID { get; set; }
        public int BusinessPlanDetailedID { get; set; }
        public int LandStatusID { get; set; }
        public int LandTypeID { get; set; }      
      
        public int BussinessPlanStatusID { get; set;}
        public int WLTStatusID { get; set; }

        public int MunicipalityHandingOverStatus { get; set; }
        public int MasterplanApprovalStatus { get; set; }
        public int InfraApprovalStatus { get; set; }
        public int InfraConstructionStatus { get; set; }


    }
}

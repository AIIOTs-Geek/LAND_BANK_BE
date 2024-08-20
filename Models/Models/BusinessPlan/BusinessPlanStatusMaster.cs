using Models.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.BusinessPlan
{
    public class BusinessPlanStatusMaster : BaseModel
    {
        public int Id { get; set; }
        public string BusinessPlanStatus { get; set; }
    }
}

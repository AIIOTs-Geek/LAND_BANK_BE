using Models.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.BusinessPlan
{
    public class BusinessPlanDetailsMaster:BaseModel
    {
        public int ID { get; set; }
        public string BusinessPlanDetails { get; set; }
    }
}

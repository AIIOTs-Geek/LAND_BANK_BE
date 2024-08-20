using Models.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.BusinessPlan
{
    public class BusinessPlanMaster : BaseModel
    {
        public int Id { get; set; }
        public string BusinessPlanName { get; set; }
    }
}

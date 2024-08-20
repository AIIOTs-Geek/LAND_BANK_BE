using Models.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.WorkFlow
{
    public class WF_InstanceMaster:BaseModel
    {
        public int Id { get; set; }
        public int InstanceId { get; set; }
        public int CurrentStageId { get; set; }
    }
}

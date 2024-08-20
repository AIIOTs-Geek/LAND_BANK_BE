using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.WorkFlow
{
    public class WF_ControlMaster
    {
        public int Id { get; set; }
        public int CurrentStage { get; set; }
        public int ActionId { get; set; }
        public int NextStage { get; set; }

    }
}

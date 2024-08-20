using Models.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.WorkFlow
{
    public class WF_StageMaster:BaseModel
    {
        public int Id { get; set; }
        public string StageName { get; set; }
        public int ProcessId { get; set; }
    }
}

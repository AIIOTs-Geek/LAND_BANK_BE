using Models.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.WorkFlow
{
    public class WF_ProcessMaster:BaseModel
    {
        public int Id { get; set; }
        public string ProcessNameAr { get; set; }
        public string ProcessNameEn { get; set; }
    }
}

using Models.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Land
{
    public class LandUseMaster:BaseModel
    {
        public int Id { get; set; }
        public string LandUse { get; set; }
        public int ParentId { get; set; }
    }
}

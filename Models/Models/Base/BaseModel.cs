using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Base
{
    public class BaseModel
    {
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedFrom { get; set; }
        public bool IsActive { get; set; }
        
    }
}

using Models.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Ownership
{
    public class TDOwnershipMaster : BaseModel

    {
        public int ID { get; set; }
        public string TDOwnership { get; set; }
    }
}

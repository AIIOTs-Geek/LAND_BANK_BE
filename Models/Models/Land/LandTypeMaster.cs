using Models.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Land
{
    public class LandTypeMaster:BaseModel
    {
        public int Id { get; set; }
        public string LandType { get; set; }
        public int ParentId { get; set; }
    }
}

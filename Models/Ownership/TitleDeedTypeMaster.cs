using Models.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Ownership
{
    public class TitleDeedTypeMaster :BaseModel
    {
        public int ID { get; set; }
        public string TDType { get; set; }

    }
}

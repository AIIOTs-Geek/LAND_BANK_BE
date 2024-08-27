using Models.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Land
{
    public class LandTitleDeedOwnerDetails:BaseModel
    {
        public int ID { get; set; }
        public int TDID { get; set; }   
        public int TDOwnerID { get; set; }  

    }
}

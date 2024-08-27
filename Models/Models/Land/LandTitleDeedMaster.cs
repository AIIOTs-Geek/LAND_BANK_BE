using Models.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Land
{
    public class LandTitleDeedMaster :BaseModel
    {
        public int ID { get; set; } 
        public int LandID { get; set; }
        public string TDNo { get; set; }
        public string TDDate { get; set; }
        public int TDType { get; set; }
        public int TDStatus { get; set; }
        public int UploadedBy { get; set; }
        public DateTime UploadedOn { get; set; }
        public string TDFileUrl { get; set; }
        public string Sequence { get; set; }



    }
}

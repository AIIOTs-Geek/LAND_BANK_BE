using Models.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Asset
{
    public class AssetMaster:BaseModel
    {
        public int Id { get; set; } 
        public string AssetName { get; set; }
        public string AssetCode { get; set; }

    }
}

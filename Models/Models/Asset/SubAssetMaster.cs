using Models.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Asset
{
    public class SubAssetMaster:BaseModel
    {
        public int Id { get; set; }
        public string SubAssetName { get; set; }
        public string SubAssetCode { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public class TitleDeed
    {
        public int TitleDeedId { get; set; }
        public string DeedDate { get; set; }
        public string? DeedStatus { get; set; }
        public string DeedNumber { get; set; }
        public string Owner { get; set; }
        public string? DeedType { get; set; }
    }
}

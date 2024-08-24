using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public class TitleDeed
    {
        public int Id { get; set; }
        public int? DeedStatus { get; set; }
        public string DeedNumber { get; set; }
        public string Owner { get; set; }
        public int? DeedType { get; set; }
    }
}

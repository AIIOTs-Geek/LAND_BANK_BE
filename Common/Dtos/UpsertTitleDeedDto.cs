using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class UpsertTitleDeedDto
    {
        public int LandId { get; set; }
        public int? TitleDeedId { get; set; }
        public int? DeedStatus { get; set; }
        public string? DeedNumber { get; set; }
        public string? DeedDate { get; set; }
        public int? DeedOwner { get; set; }
        public int? DeedType { get; set; }
        public string? DeedUrl { get; set; }
        public int? DeedSequence { get; set; }
    }
}

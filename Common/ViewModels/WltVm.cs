using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public class WltWrapperVm
    {
        public string Year { get; set; }
        public List<WltDetailsVm> WltDetails { get; set; }
    }
}

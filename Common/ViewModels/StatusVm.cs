using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public class StatusVm
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int? ParentId { get; set; }
        public List<StatusVm> Children { get; set; } = new List<StatusVm>();
        public List<StatusVm> Grandchildren { get; set; } = new List<StatusVm>();
    }


}

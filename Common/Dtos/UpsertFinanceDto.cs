using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class UpsertFinanceDto
    {
     
        public int LandId {  get; set; }
        public List<int> TypeIds { get; set; }
        public List<decimal>? Value { get; set; }
        public DateTime Date { get; set; }
        public int ValuationConsultantId { get; set; }
    }
}

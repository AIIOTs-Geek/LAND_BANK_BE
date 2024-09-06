using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class UpsertFinanceDto
    {
        public int? UserId { get; set; }
        public int LandId {  get; set; }
        public int TypeId { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public int ValuationConsultantId { get; set; }
    }
}

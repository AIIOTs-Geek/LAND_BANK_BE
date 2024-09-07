using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class UpsertFinanceDto
    {

        public int LandId { get; set; }      
        public decimal? BookValue { get; set; }
        public decimal? CostPer { get; set; }
        public decimal? LatestValue { get; set; }     
       
        public int? ZakatPayment { get; set; }
        public int? ZakatImplication { get; set; }

    }
}

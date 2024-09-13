using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public class FinanceVm
    {
        public decimal? Area { get; set; }
        public decimal? LatestValue { get; set; }
        public decimal? PriceValue { get; set; }
        public decimal? BookValue { get; set; }
        public decimal? CostPerPrice { get; set; }
        public string? ZakatImplication { get; set; } 
        public decimal? ZakatValue { get; set; }
        public string? ZakatPayment { get; set; }
        public List<Graph>? MapData { get; set; }
    }

    public class Graph
    {
        public decimal Value { get; set; }
        public int Year { get; set; }
    }
}


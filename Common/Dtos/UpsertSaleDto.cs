using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class UpsertSaleDto
    {
        public int? LandId { get; set; }
        public string? ReferenceNumber { get; set; }
        public int? SalesMethodId { get; set; }
        public int? SalesStatusId { get; set; }
        public decimal? Commission { get; set; }
        public decimal? SaleValue { get; set; }
        public DateTime? SaleDate { get; set; }
        public int? SalesRepresentative { get; set; }
        public int? AgentName { get; set; }
        public int? BuyerId { get; set; }
    }
}
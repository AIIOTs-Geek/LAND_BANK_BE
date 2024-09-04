using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class AddBuyerDto
    {
        public int? Id { get; set; }
        public string? BuyerId { get; set; }
        public string? BuyerName { get; set; }
        public string? BuyerEmail { get; set; }
        public string? BuyerMobile { get; set; }
        public int? CompanyId { get; set; }
    }
}

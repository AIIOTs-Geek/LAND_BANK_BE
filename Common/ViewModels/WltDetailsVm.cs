using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public class WltDetailsVm
    {
        public string TDNumber { get; set; }
        public string Amount { get; set; }
        public string InvoiceNumber { get; set; }
        public string DueDate { get; set; }
        public string PaymentDeadline { get; set; }
        public string NotificationDate { get; set; }
        public string PaymentStatus { get; set; }
        public string ObjectionDeadline { get; set; }
        public string ObjectionStatus { get; set; }
        public string ObjectionDesc { get; set; }
    }
}

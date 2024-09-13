using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public class WltDetailsVm
    {
        public int TDId { get; set; }
        //public string TDNumber { get; set; }
        public string Amount { get; set; }
        public string InvoiceNumber { get; set; }
        public string DueDate { get; set; }
        public string PaymentDeadline { get; set; }
        public string NotificationDate { get; set; }
        public string PaymentStatus { get; set; }
        public string ObjDeadline { get; set; }
        public string ObjStatus { get; set; }
        public string ObjDescription { get; set; }
    }
}

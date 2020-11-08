using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxITP245.Models
{
    public class PurchaseOrder
    {
        public int PurchaseOrderNumber { get; set; }
        public int VendorID { get; set; }
        public Vendor Vendor { get; set; }
        public DateTime PoDate { get; set; }
        public decimal Amount { get; set; }
    }
}
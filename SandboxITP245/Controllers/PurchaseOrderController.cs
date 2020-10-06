using SandboxITP245.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SandboxITP245.Controllers
{
    public class PurchaseOrderController : Controller
    {
        // GET: PurchaseOrder
        public ActionResult Index()
        {
            var purchaseOrders = from po in GetPurchaseOrders()
                                 orderby po.PurchaseOrderNumber
                                 select po;
            return View(purchaseOrders);
        }

        public List<PurchaseOrder> GetPurchaseOrders()
        {
            return new List<PurchaseOrder>
            {
                new PurchaseOrder
                {
                    PurchaseOrderNumber = 8675309,
                    PoDate = new DateTime(1963, 10, 9),
                    VendorID = 509,
                    Vendor = new Vendor("Vendor1"),
                    Amount = 109323
                },
                new PurchaseOrder
                {
                    PurchaseOrderNumber = 0000804,
                    PoDate = new DateTime(1997, 1, 24),
                    VendorID = 028,
                    Vendor = new Vendor("Vendor 2"),
                    Amount = 24025
                },
                new PurchaseOrder
                {
                    PurchaseOrderNumber = 6042009,
                    PoDate = new DateTime(2019, 3, 17),
                    VendorID = 369,
                    Vendor = new Vendor("Vendor 3"),
                    Amount = 998482
                }
            };
        }
    }
}
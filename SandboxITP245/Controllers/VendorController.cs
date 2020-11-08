using SandboxITP245.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SandboxITP245.Controllers
{
    public class VendorController : Controller
    {
        // GET: Vendor
        public ActionResult Index()
        {
            var vendors = from v in GetVendorsList()
                          orderby v.VendorId
                          select v;
            return View(vendors);
        }

        public List<Vendor> GetVendorsList()
        {
            return new List<Vendor>
            {
                new Vendor("Yellow Smiley Face Corp.")
                {
                    VendorId = 0001,
                    Address1 = "200 Walton Way",
                    Address2 = "Unit A",
                    City = "Bentonville",
                    State = "AR",
                    ZipCode = "50942",
                    Email = "sam@WallyWorld.com",
                    Contact = "Sam Walton"
                },

                new Vendor("Believe Me Folks")
                {
                    VendorId = 0003,
                    Address1 = "Yuge Tower",
                    Address2 = "500 Park Ave",
                    City = "Bigly",
                    State = "NY",
                    ZipCode = "10245",
                    Email = "Donny@BigHands.com",
                    Contact = "John Miller"
                },
                new Vendor("Free Fall Construction")
                {
                    VendorId = 0002,
                    Address1 = "2001 Freedom Plaza",
                    Address2 = "Building 7",
                    City = "Liberty City",
                    State = "NY",
                    ZipCode = "10012",
                    Email = "noreply@pullit.com",
                    Contact = "Richard Chainie"
                },

            };
        }
    }
}
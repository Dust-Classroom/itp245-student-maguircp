using SandboxITP245.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SandboxITP245.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            var items = from i in GetItemsList()
                        select i;
            return View(items);
        }

        public List<Item> GetItemsList()
        {
            return new List<Item>
            {
                 new Item
                {
                    ItemID = 0,
                    Name = "AudioTechina Vinyl Record Player",
                    Description = "Dust off those old Funkadelic vinyls and get your groove on!",
                    ImageLocation = "FakeLocation.com/MaggotBrain.jpg",
                    QuantityOnHand = 3,
                    RetailPrice = 150,
                    StandardCost = 65

                },

                new Item
                {
                    ItemID = 1,
                    Name = "Google Chromecast",
                    Description = "This device can be used to stream digital content on your television",
                    ImageLocation = "FakeLocation.com/Chromecast.jpg",
                    QuantityOnHand = 105,
                    RetailPrice = 50,
                    StandardCost = 15

                },

                new Item
                {
                    ItemID = 2,
                    Name = "Google Home Mini",
                    Description = "Digital assistant to integrate within any smart home ecosystem",
                    ImageLocation = "FakeLocation.com/HomeMini.jpg",
                    QuantityOnHand = 30,
                    RetailPrice = 30,
                    StandardCost = 9

                },

            };
        }
    }
}
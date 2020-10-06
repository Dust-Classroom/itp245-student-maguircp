using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SandboxITP245.Models
{
    public class Item
    {
        public int ItemID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
        public int QuantityOnHand { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal StandardCost { get; set; }

        [StringLength(200)]
        public string ImageLocation { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SandboxITP245.Models
{
    public class Vendor
    {
        public Vendor (string vendorName)
        {
            Name = vendorName;
        }
        public int VendorId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Contact { get; set; }
        [StringLength(50)]
        public string Address1 { get; set; }
        [StringLength(50)]
        public string Address2 { get; set; }
        [StringLength(30)]
        public string City { get; set; }
        [StringLength(5)]
        public string State { get; set; }
        [StringLength(5)]
        public string ZipCode { get; set; }
        public string Email { get; set; }
    }


}
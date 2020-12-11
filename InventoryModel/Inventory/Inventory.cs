using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web;

namespace InventoryModel.Inventory
{

        [MetadataType(typeof(CategoryMetadata))]
        public partial class Category
        {
            private sealed class CategoryMetadata
            {
                [Display(Name = "Category")]
                public string Name { get; set; }

                [Display(Name ="Category ID")]
                public int CategoryId { get; set; }
            }
        }

    [MetadataType(typeof(ItemMetadata))]
    public partial class Item
    {
        private sealed class ItemMetadata
        {
            [Display(Name = "Item")]
            public string Name { get; set; }

            [Display(Name = "Category")]
            public int CategoryId { get; set; }

            [Display(Name = "Quantity On Hand")]
            public int QuantityOnHand { get; set; }

            [Display(Name = "Retail Price")]
            [DataType(DataType.Currency)]
            public double RetailPrice { get; set; }

            [Display(Name = "Standard Cost")]
            [DataType(DataType.Currency)]
            public double StandardCost { get; set; }
        }

        public HttpPostedFileBase FileName {get; set;}

     }

        [MetadataType(typeof(SpoilageMetadata))]
        public partial class Spoilage
        {
            private sealed class SpoilageMetadata
            {
                [Display(Name = "Reason Type")]
                 public int ReasonType { get; set; }

                [Display(Name ="Expiration Date")]
                
                public DateTime SpoilageDate { get; set; }

                [Display(Name = "Description")]
                public string Description { get; set; }

                [DataType(DataType.Currency)]
                public double Value { get; set; }

        }
        }

        [MetadataType(typeof(PurchaseOrderMetadata))]
        public partial class PurchaseOrder
        {
            private sealed class PurchaseOrderMetadata
            {
                [Display(Name = "Purchase Order")]
                public int PurchaseOrderNumber { get; set; }

                [Display(Name = "Order Date")]
                public DateTime PoDate { get; set; }

                [Display(Name = "Vendor")]
                public string VendorId { get; set; }

                [DataType(DataType.Currency)]
                public double Amount { get; set; }

        }
        }

        [MetadataType(typeof(VendorMetadata))]
        public partial class Vendor
    {
        private sealed class VendorMetadata
        {
            [Display(Name = "Vendor")]
            public string Name { get; set; }

            [Display(Name = "Address")]
            public DateTime Address1 { get; set; }

            [Display(Name = "Zip")]
            public string ZipCode { get; set; }

            [Display(Name = "Phone")]
            public string PhoneNumber { get; set; }

        }
    }

}
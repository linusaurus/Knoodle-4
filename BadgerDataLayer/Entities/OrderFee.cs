using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class OrderFee
    {
        public int OrderfeeID { get; set; }
        public string FeeName { get; set; }
        public decimal? Qnty { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Extension { get; set; }
        public int? PurchaseOrderID { get; set; }

        //--Relationship
        public PurchaseOrder PurchaseOrder { get; set; }
    }
}

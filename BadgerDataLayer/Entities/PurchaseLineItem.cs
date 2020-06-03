using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class PurchaseLineItem
    {
        public int LineID { get; set; }
        public int? PurchaseOrderId { get; set; }
        public int? JobId { get; set; }
        public int? VendorId { get; set; }
        public int? PartID { get; set; }
        public decimal? UnitCost { get; set; }
        public string Description { get; set; }
        public decimal? Qnty { get; set; }
        public decimal? Extended { get; set; }
        public bool? Recieved { get; set; }
        public int? OrderReceiptId { get; set; }
     
        public int? Uom { get; set; }
        public string UoP { get; set; }
        public int? ArticleId { get; set; }
        public int? BomId { get; set; }
        public decimal? AmountReceived { get; set; }
        public decimal? Width { get; set; }
        public decimal? Length { get; set; }
        public decimal? Thick { get; set; }
        public decimal? Weight { get; set; }
        public string SupplierPartName { get; set; }
        public decimal? UoPprice { get; set; }
        public string Bcode { get; set; }
        public string Note { get; set; }
        public bool? Rejected { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}

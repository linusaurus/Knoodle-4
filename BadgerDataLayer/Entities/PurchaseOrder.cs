using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            Attachment = new List<Attachment>();
            Notification = new HashSet<Notification>();
            PurchaseLineItem = new List<PurchaseLineItem>();
            OrderFee = new List<OrderFee>();
        }

        public int OrderNum { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public int? SupplierId { get; set; }
        public int? EmployeeId { get; set; }
        public string SalesRep { get; set; }
        public int? JobId { get; set; }
        public bool? SuppressTax { get; set; }
        public int? ShipId { get; set; }
        public decimal? OrderTotal { get; set; }
        public bool? Recieved { get; set; }
        public decimal? ShippingCost { get; set; }
        public decimal? Tax { get; set; }
        public bool? IsBackOrder { get; set; }
        public DateTime? RecievedDate { get; set; }
        public decimal? SubTotal { get; set; }
        public string Memo { get; set; }
        public int? OrderState { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string OrderFormat { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Job Job { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<OrderFee> OrderFee { get; set; }
        public virtual ICollection<Attachment> Attachment { get; set; }
        public virtual ICollection<Notification> Notification { get; set; }
        public virtual IList<PurchaseLineItem> PurchaseLineItem { get; set; }
    }
}

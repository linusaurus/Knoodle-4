using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Supplier
    {
        public Supplier()
        {
            Part = new HashSet<Part>();
            PurchaseOrder = new HashSet<PurchaseOrder>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string Zip { get; set; }
        public bool? Active { get; set; }
        public int? Category { get; set; }
        public int? AccountType { get; set; }
        public string AccountNumber { get; set; }

        public virtual ICollection<Part> Part { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; }
    }
}

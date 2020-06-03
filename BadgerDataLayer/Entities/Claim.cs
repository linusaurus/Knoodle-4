using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Claim
    {
        public int ClaimId { get; set; }
        public int? SupplierId { get; set; }
        public int? OrderNum { get; set; }
        public string SupplierOrder { get; set; }
        public DateTime? ClaimDate { get; set; }
        public int? EmployeeId { get; set; }

        public Supplier Supplier { get; set; }
        public List<ClaimItem> ClaimItems { get; set; }
    }
}

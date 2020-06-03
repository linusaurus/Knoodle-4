using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Recieving
    {
        public int OrderReceiptId { get; set; }
        public string Firstname { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public int? OrderNum { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Jobname { get; set; }
        public string SupplierName { get; set; }
    }
}

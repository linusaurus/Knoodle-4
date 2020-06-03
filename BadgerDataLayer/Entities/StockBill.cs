using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class StockBill
    {
       
        public int StockBillId { get; set; }
        public int? JobId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? StockBillDate { get; set; }
        public decimal? ItemTotal { get; set; }
        public bool? Submitted { get; set; }

       
    }
}

using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Inventory
    {
        public int StockTransactionID { get; set; }
        public int? OrderReceiptID { get; set; }
        public int? LineID { get; set; }
        public int? PartID { get; set; }
        public int? StockBillID { get; set; }
        public int? JobId { get; set; }
        public string Location { get; set; }
        public int? ArticleID { get; set; }
        public DateTime? DateStamp { get; set; }
        public decimal? Qnty { get; set; }
        public decimal? QntyRecvd { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public int? UnitOfMeasure { get; set; }
        public int? TransActionType { get; set; }
        public int? Emp_id { get; set; }

        public OrderReciept OrderReceipt { get; set; }
        public StockBill StockBill { get; set; }
        public Job GetJob { get; set; }
    }
}
